using System;
using System.Xml.Serialization;
using System.Collections.ObjectModel;

namespace Employees
{
    [XmlRoot("root")]
    public class Employees
    {
        [XmlArray("employees")]
        [XmlArrayItem("employee")]
        public ObservableCollection<Employee> Collection { get; set; }
    }
}
