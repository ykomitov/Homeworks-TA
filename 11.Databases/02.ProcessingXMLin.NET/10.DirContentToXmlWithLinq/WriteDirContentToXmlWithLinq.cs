namespace Processing.Xml
{
    using System;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    public class WriteDirContentToXmlWithLinq
    {
        public static void Main()
        {
            // Select the directory you have to search.
            string pathToDirectory = "../../../";
            System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(pathToDirectory);

            using (XmlWriter writer = XmlWriter.Create("../../directoryContent.xml"))
            {
                XDocument rootDocument = new XDocument(new XElement("root"));
                XElement finalDocument = SaveDirectoryTreeToXml(writer, rootDocument.Element("root"), directory);

                finalDocument.Save(writer);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("File created! Press any key to exit.");
            Console.ReadKey();
        }

        public static XElement SaveDirectoryTreeToXml(XmlWriter writer, XElement element, System.IO.DirectoryInfo root)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            // First, process all the files directly under the root folder
            try
            {
                files = root.GetFiles("*.*");
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    element.Add(new XElement("file", fi.Name));
                }

                // Find all the subdirectories under this directory.
                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    element.Add(new XElement("dir", new XAttribute("name", dirInfo.Name)));

                    // Recursive call, selecting each distinct name attribute
                    SaveDirectoryTreeToXml(writer, element.Elements("dir").First(x => x.Attribute("name").Value == dirInfo.Name), dirInfo);
                }
            }

            return element;
        }
    }
}
