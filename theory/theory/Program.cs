using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace theory
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cities = new List<City>();
            //XmlDocument xmlDocument = new XmlDocument();
            //xmlDocument.Load("dataXML.xml");

            //var rootElement = xmlDocument.DocumentElement;
            //foreach(XmlElement child in rootElement.ChildNodes)
            //{
            //    var idElement = child.GetElementsByTagName("id")[0];

            //    if (idElement.Name == "id")
            //    {
            //        var idType = (idElement as XmlElement).GetAttribute("type");
            //        if (idType == "int") continue;
            //    }

            //    var nameElement = child.GetElementsByTagName("name")[0];
            //    var countryNameElement = child.GetElementsByTagName("countryName")[0];
            //    var latitudeElement = child.GetElementsByTagName("latitude")[0];
            //    var longitudeElement = child.GetElementsByTagName("longitude")[0];


            //    var city = new City
            //    {
            //        Id = Guid.Parse(idElement.InnerText),
            //        Name = nameElement.InnerText,
            //        CountryName = countryNameElement.InnerText,
            //        Longitude = double.Parse(longitudeElement.InnerText),
            //        Latitude = double.Parse(latitudeElement.InnerText),
            //    };
            //    cities.Add(city);
            // Console.ReadLine();
            //}

            var city = new City
            {
                Name = "Karaganda",
                CountryName = "Kazakhstan",
                Latitude = 25.6,
                Longitude = 12.4,
            };
            XmlDocument xmlDocument = new XmlDocument();
            var rootElement = xmlDocument.CreateElement("city");
            
            var idElement = xmlDocument.CreateElement("id");
            idElement.SetAttribute("type", "Guid");
            idElement.InnerText = city.Id.ToString();

            var nameElement = xmlDocument.CreateElement("name");
            nameElement.InnerText = city.Name;

            var countryNameElement = xmlDocument.CreateElement("countryName");
            countryNameElement.InnerText = city.CountryName;

            var longitudeElement = xmlDocument.CreateElement("longitude");
            longitudeElement.InnerText = city.Longitude.ToString();

            var latitudeElement = xmlDocument.CreateElement("latitude");
            latitudeElement.InnerText = city.Latitude.ToString();

            rootElement.AppendChild(idElement);
            rootElement.AppendChild(nameElement);
            rootElement.AppendChild(countryNameElement);
            rootElement.AppendChild(latitudeElement);
            rootElement.AppendChild(longitudeElement);

            xmlDocument.AppendChild(rootElement);

            xmlDocument.Save("data4.xml");

        }
    }
}
