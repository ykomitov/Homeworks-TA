namespace Processing.Xml
{
    using System;
    using System.Text;
    using System.Xml;

    public class CreateXmlFromFile
    {
        public static void Main()
        {
            string line;
            string fileName = "sample.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            string[] tags = { "name", "address", "phone" };

            using (System.IO.StreamReader reader = new System.IO.StreamReader("../../sample.txt"))
            {
                using (XmlTextWriter writer = new XmlTextWriter("../../" + fileName, encoding))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.IndentChar = '\t';
                    writer.Indentation = 1;

                    writer.WriteStartDocument();
                    writer.WriteStartElement("person");
                    writer.WriteAttributeString("name", "Person Details");

                    // Read the input file line by line.
                    for (int i = 0; i < tags.Length; i++)
                    {
                        line = reader.ReadLine();
                        writer.WriteStartElement(tags[i]);
                        writer.WriteValue(line);
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                }
            }

            Console.WriteLine("Document {0} created.", fileName);

            // Suspend the screen.
            Console.ReadLine();
        }
    }
}
