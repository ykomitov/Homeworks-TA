//Write a program that concatenates two text files into another text file.

using System;
using System.IO;

namespace ConcatenateTextFiles
{
    public class ConcatenateTextFiles
    {
        static void Main()
        {
            string path1 = "../../TextFile1.txt";
            string path2 = "../../TextFile2.txt";
            string outputPath = "../../TextFileResult.txt";

            try
            {
                //Merge the two text files
                MergeFiles(path1, path2, outputPath);

                //Print File 1
                Console.WriteLine("File 1:");
                StreamReader reader = new StreamReader("../../TextFile1.txt");
                PrintReader(reader);

                //Print File 2
                Console.WriteLine("File 2:");
                reader = new StreamReader("../../TextFile2.txt");
                PrintReader(reader);
                reader.Close();

                //Print merged file
                Console.WriteLine("Merged File:");
                reader = new StreamReader("../../TextFileResult.txt");
                PrintReader(reader);
                reader.Close();

                //Delete merged file
                File.Delete("../../TextFileResult.txt");
            }
            catch (Exception)
            {
                Console.WriteLine("Merge not successful!");
            }

        }
        static void MergeFiles(string pathFile1, string pathFile2, string pathResult)
        {
            File.WriteAllText(pathResult, File.ReadAllText(pathFile1) + "\r\n" + File.ReadAllText(pathFile2));
        }

        public static void PrintReader(StreamReader reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine("Line: {0}", line);
                line = reader.ReadLine();
                lineNumber++;
            }
            Console.WriteLine();
        }
    }
}