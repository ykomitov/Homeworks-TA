/*Write a program to traverse given directory and write to a XML file its contents together with all subdirectories and files.

    Use tags <file> and <dir> with appropriate attributes.
    For the generation of the XML document use the class XmlWriter*/

namespace Processing.Xml
{
    using System;
    using System.Xml;

    public class WriteDirContentToXml
    {
        public static void Main()
        {

            // Select the directory you have to search.
            string pathToDirectory = "../../../";
            System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(pathToDirectory);

            using (XmlWriter writer = XmlWriter.Create("../../directoryContent.xml"))
            {
                writer.WriteStartDocument();

                // Write the Root Element
                writer.WriteStartElement("root");

                SaveDirectoryTreeToXml(writer, directory);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("File created! Press any key to exit.");
            Console.ReadKey();
        }

        public static void SaveDirectoryTreeToXml(XmlWriter writer, System.IO.DirectoryInfo root)
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
                    writer.WriteStartElement("file");
                    writer.WriteValue(fi.Name);
                    writer.WriteEndElement();
                }

                // Find all the subdirectories under this directory.
                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    writer.WriteStartElement("dir");
                    writer.WriteAttributeString("name", dirInfo.Name);
                    SaveDirectoryTreeToXml(writer, dirInfo);
                    writer.WriteEndElement();
                }
            }
        }
    }
}