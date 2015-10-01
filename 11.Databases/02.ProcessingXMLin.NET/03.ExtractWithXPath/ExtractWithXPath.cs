namespace Processing.Xml
{
    using System;
    using System.Collections;
    using System.Xml.XPath;

    public class ExtractWithXPath
    {
        public static void Main()
        {
            Hashtable artistsList = new Hashtable();
            var doc = new XPathDocument("../../../01.catalogue.xml");
            var nav = doc.CreateNavigator();
            var artists = nav.Select("/catalogue/album/artist");

            foreach (XPathNavigator artist in artists)
            {
                string xPathQuery = "count(/catalogue/album/artist[contains(., '" + artist.Value + "')])";
                var countAlbums = nav.Evaluate(xPathQuery);

                if (!artistsList.Contains(artist.Value))
                {
                    artistsList[artist.Value] = countAlbums;
                }
            }

            Console.WriteLine("Using XPath:\r\n");

            HelperMethods.PrintHashTable(artistsList);
        }
    }
}
