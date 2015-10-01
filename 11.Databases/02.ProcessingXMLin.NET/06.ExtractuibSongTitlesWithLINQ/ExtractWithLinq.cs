namespace Processing.Xml
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class ExtractWithLinq
    {
        public static void Main()
        {
            XDocument xmlDoc = XDocument.Load("../../../01.catalogue.xml");
            var titles =
                from song in xmlDoc.Descendants("song")
                select new
                {
                    Title = song.Element("title").Value,
                };

            Console.WriteLine("Found {0} songs:\r\n", titles.Count());

            var counter = 1;
            foreach (var title in titles)
            {
                Console.WriteLine("{0}. {1}", counter, title.Title);
                counter++;
            }
        }
    }
}
