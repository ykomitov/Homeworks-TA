/*Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier.

    Use LINQ query.*/

namespace Processing.Xml
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;

    public class ExtractAlbumsWithLinq
    {
        public const byte NumberOfYears = 5;

        public static void Main()
        {
            DateTime dt = DateTime.Now;
            var year = dt.Year - NumberOfYears;

            XElement root = XElement.Load("../../../01.CreateXml/catalogue.xml");

            // Select all nodes where year is matching criteria.
            IEnumerable<XElement> queryResult = root.Descendants("album")
                                                       .Where(x => (int)x.Element("year") < year)

                                                    // .Select(y => y.Element("name"))
                                                       .ToList();

            Console.WriteLine("Albums, published {0} years ago or earlier (before {1}):\r\n", NumberOfYears, year);

            foreach (XElement item in queryResult)
            {
                Console.WriteLine(
                    "{0}: {1} - {2}",
                    item.Element("year").Value,
                    item.Element("name").Value,
                    item.Element("artist").Value);
            }
        }
    }
}
