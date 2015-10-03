/*Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier.

    Use XPath query.*/

namespace Processing.Xml
{
    using System;
    using System.Xml;

    public class ExtractAlbums
    {
        public const byte NumberOfYears = 5;

        public static void Main()
        {
            DateTime dt = DateTime.Now;
            var year = dt.Year - NumberOfYears;

            XmlDocument doc = new XmlDocument();
            doc.Load("../../../01.CreateXml/catalogue.xml");
            XmlNode root = doc.DocumentElement;

            // Select all nodes where year is matching criteria.
            XmlNodeList nodeList = root.SelectNodes("//album[year<" + year + "]");

            Console.WriteLine("Albums, published {0} years ago or earlier (before {1}):\r\n", NumberOfYears, year);
            foreach (XmlNode item in nodeList)
            {
                Console.WriteLine(
                    "{0}: {1} - {2}",
                    item.SelectSingleNode("year").InnerText,
                    item.SelectSingleNode("name").InnerText,
                    item.SelectSingleNode("artist").InnerText);
            }
        }
    }
}
