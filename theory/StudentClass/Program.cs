using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlStudent = new XmlDocument();

            XmlElement student = xmlStudent.CreateElement("Student");

            XmlAttribute nameAttr = xmlStudent.CreateAttribute("Name");
            nameAttr.Value = "Aslan";
            student.Attributes.Append(nameAttr);

            XmlAttribute univAttr = xmlStudent.CreateAttribute("University");
            univAttr.Value = "Oxford";
            student.Attributes.Append(univAttr);

            XmlAttribute homeTownAttr = xmlStudent.CreateAttribute("Motherland");
            homeTownAttr.Value = "Astana";
            student.Attributes.Append(homeTownAttr);

            Console.WriteLine(nameAttr.InnerText + "\n"+ univAttr.InnerText + "\n"+homeTownAttr.InnerText);
             
            Console.ReadLine();
        }

        
    }
}
