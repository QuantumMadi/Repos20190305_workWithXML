using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace HabrHabr
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Item>));

            var xRoot = DownLoadData();
          
            foreach(XmlNode xnode in xRoot)
            {
               

                foreach (XmlNode habrItems in xnode.ChildNodes) {
                    Item item = new Item();
                    if (habrItems.Name == "item")
                    {
                        foreach(XmlNode child in habrItems.ChildNodes)
                        {
                            if (child.Name == "title") item.Title = child.InnerText;
                            if (child.Name == "link") item.Link = child.InnerText;
                            if (child.Name == "description") item.Description = child.InnerText;
                            if (child.Name == "pubDate") item.PubDate = child.InnerText;
                        }                     
                    }
                    items.Add(item);
                }
              
                
            }
            Console.ReadLine();
        }

        public static XmlElement DownLoadData()
        {           
            WebClient webClient = new WebClient();
            var xmlFile = Encoding.UTF8.GetString(webClient.DownloadData("https://habrahabr.ru/rss/interesting/"));
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlFile);
            XmlElement xRoot = xmlDoc.DocumentElement;

            return xRoot;
        }
    }
}
