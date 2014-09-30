using System;
using System.Xml.Serialization;

namespace Employees
{
    public class Employee
    {
        [XmlElement("firstName")]
        public string firstName { get; set; }

        [XmlElement("lastName")]
        public string lastName { get; set; }

        [XmlElement("title")]
        public string title { get; set; }

        [XmlElement("phone")]
        public string phone { get; set; }

        [XmlElement("email")]
        public string email { get; set; }

        [XmlElement("room")]
        public string room { get; set; }

        [XmlElement("picture")]
        public string picture { get; set; }

        [XmlElement("info")]
        public string info { get; set; }
    }
}
