namespace Processing.Xml
{
    using System;
    using System.Collections;
    using System.Xml;

    public class ExtractArtists
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../01.CreateXml/catalogue.xml");
            XmlNode rootNode = doc.DocumentElement;
            XmlNodeList artists = rootNode.SelectNodes("/catalogue/album/artist");
            Hashtable artistsList = new Hashtable();

            foreach (XmlNode artist in artists)
            {
                // if artist is not in the list - add it with album count = 1
                if (!artistsList.Contains(artist.InnerText))
                {
                    artistsList[artist.InnerText] = 1;
                }
                else
                {
                    // if artist is already in the hash table parse the number of albums (from the list)
                    int albumCount = int.Parse(artistsList[artist.InnerText].ToString());
                    albumCount++; // increase the count

                    artistsList[artist.InnerText] = albumCount; // update the count in the hash table
                }
            }

            Console.WriteLine("Using the DOM parser:\r\n");

            HelperMethods.PrintHashTable(artistsList);
        }
    }
}
