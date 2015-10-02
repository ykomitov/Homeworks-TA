namespace Processing.Xml
{
    using System;
    using System.Xml;

    public class ExtractSongTitles
    {
        public static void Main()
        {
            Console.WriteLine("Song titles in the catalogue:\r\n");
            using (XmlReader reader = XmlReader.Create("../../../01.CreateXml/catalogue.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
