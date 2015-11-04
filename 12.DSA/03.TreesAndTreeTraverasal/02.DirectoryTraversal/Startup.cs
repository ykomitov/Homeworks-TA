/* Write a program to traverse the directory C:\WINDOWS and all its subdirectories recursively and to display all files matching the mask *.exe. Use the class System.IO.Directory. */

namespace _02.DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            ////var rootDir = "C:\\WINDOWS";
            var rootDir = "../../testDir";

            var listOfExes = GetExesIsDirectory(rootDir);

            Console.WriteLine("Number of .exe files in {0} is {1}.", rootDir, listOfExes.Count);
            Console.WriteLine("\r\nList of executables:");
            Console.WriteLine(string.Join(", ", listOfExes));
        }

        public static List<string> GetExesIsDirectory(string rootDir)
        {
            var listOfExecutables = new List<string>();

            listOfExecutables = Directory.GetFiles(rootDir, "*.exe")
                                     .Select(path => Path.GetFileName(path))
                                     .ToList();

            try
            {
                foreach (string dir in Directory.GetDirectories(rootDir))
                {
                    listOfExecutables.AddRange(GetExesIsDirectory(dir));
                }
            }
            catch (Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }

            return listOfExecutables;
        }
    }
}
