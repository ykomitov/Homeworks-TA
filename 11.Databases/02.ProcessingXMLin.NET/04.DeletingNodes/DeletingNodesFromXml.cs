namespace Processing.Xml
{
    using System;
    using System.Globalization;
    using System.Xml;

    public class DeletingNodesFromXml
    {
        public static void Main()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../catalogue-with-albums-to-delete.xml");
            bool nodesDeleted = false;

            XmlNodeList nodes = doc.SelectNodes("/catalogue/album");
            for (int i = nodes.Count - 1; i >= 0; i--)
            {
                string price = nodes[i].SelectSingleNode("price").InnerText;

                if (double.Parse(price, CultureInfo.InvariantCulture) > 20)
                {
                    nodesDeleted = true;
                    nodes[i].ParentNode.RemoveChild(nodes[i]);
                }
            }

            if (nodesDeleted)
            {
                Console.WriteLine("File has been updated. Albums with price > 20 have been deleted!");
            }
            else
            {
                Console.WriteLine("There are no albums with price > 20!");
            }

            doc.Save("../../catalogue-with-albums-to-delete.xml");
        }
    }
}
