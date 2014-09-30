using System;
using Microsoft.Phone.Controls;
using System.Windows;
using System.Net;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Windows.Controls;

namespace Employees
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            // is there network connection available
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                MessageBox.Show("No network connection available!");
                return;
            }
            // start loading XML-data
            WebClient downloader = new WebClient();
            Uri uri = new Uri("http://ptm.fi/wp/Employees/employees.xml", UriKind.Absolute);
            downloader.DownloadStringCompleted += new DownloadStringCompletedEventHandler(EmployeesDownloaded);
            downloader.DownloadStringAsync(uri);
        }

        void EmployeesDownloaded(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Result == null || e.Error != null)
            {
                MessageBox.Show("There was an error downloading the XML-file!");
            }
            else
            {
                // Deserialize if download succeeds
                XmlSerializer serializer = new XmlSerializer(typeof(Employees));
                XDocument document = XDocument.Parse(e.Result);
                Employees employees = (Employees) serializer.Deserialize(document.CreateReader());
                employeesList.ItemsSource = employees.Collection;
            }
        }

        // selection in EmployeeList is changed
        private void employeesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var app = App.Current as App;
            app.selectedEmployee = (Employee) employeesList.SelectedItem;
            this.NavigationService.Navigate(new Uri("/EmployeePage.xaml", UriKind.Relative));
        }


    }
}