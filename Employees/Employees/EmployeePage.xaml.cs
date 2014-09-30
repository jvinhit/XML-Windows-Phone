using System;
using Microsoft.Phone.Tasks;
using Microsoft.Phone.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Input;
using System.Windows;

namespace Employees
{
    public partial class EmployeePage : PhoneApplicationPage
    {
        // selected Employee
        Employee employee;

        public EmployeePage()
        {
            InitializeComponent();

            // get selected employee from App Class
            var app = App.Current as App;
            employee = app.selectedEmployee;

            // show employee details in page
            lastName.Text = employee.lastName;
            firstName.Text = employee.firstName;
            title.Text = employee.title;
            room.Text = "Room: " + employee.room;
            image.Source = new BitmapImage(new Uri(employee.picture, UriKind.RelativeOrAbsolute));
            mail.Text = "Email: " + employee.email;
            sms.Text = "SMS: " + employee.phone;
            phone.Text = "Call: " + employee.phone;
            info.Text = employee.info;
        }


        private void phone_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Make a phone call?", employee.lastName + " " + employee.firstName, MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                // make a phone call
                PhoneCallTask phoneTask = new PhoneCallTask();
                phoneTask.DisplayName = employee.lastName + " " + employee.firstName;
                phoneTask.PhoneNumber = employee.phone;
                phoneTask.Show();
            }
        }

        private void sms_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Send SMS message?", employee.lastName + " " + employee.firstName, MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                // sms
                SmsComposeTask composeSMS = new SmsComposeTask();
                composeSMS.Body = "Edit your message";
                composeSMS.To = employee.phone;
                composeSMS.Show();
            }
        }

        private void mail_ManipulationStarted(object sender, ManipulationStartedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Send Email?", employee.lastName + " " + employee.firstName, MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                // sähköposti
                EmailComposeTask emailcomposer = new EmailComposeTask();
                emailcomposer.To = "<a href=\"mailto:" + employee.email + "\">" + employee.email + "</a>";
                emailcomposer.Subject = "Edit your Subject";
                emailcomposer.Body = "Edit your Message";
                emailcomposer.Show();
            }
        }
    }
}