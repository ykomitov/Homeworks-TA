namespace Processing.Xml
{
    using System;
    using System.Xml;

    public class CreateAlbumsXml
    {
        public static void Main()
        {
            string fileName = "album.xml";
            using (XmlReader reader = XmlReader.Create("../../../01.CreateXml/catalogue.xml"))
            {
                using (XmlWriter writer = XmlWriter.Create("../../" + fileName))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("albums");
                    while (reader.Read())
                    {
                        if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "album"))
                        {
                            writer.WriteStartElement("album");
                        }

                        if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "name"))
                        {
                            writer.WriteStartElement("name");
                            writer.WriteValue(reader.ReadInnerXml());
                            writer.WriteEndElement();
                        }

                        if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "artist"))
                        {
                            writer.WriteStartElement("artist");
                            writer.WriteValue(reader.ReadInnerXml());
                            writer.WriteEndElement();
                            writer.WriteEndElement();
                        }
                    }
                }
            }

            Console.WriteLine("Document {0} created.", fileName);

            // Suspend the screen.
            Console.ReadLine();
        }
    }
}
