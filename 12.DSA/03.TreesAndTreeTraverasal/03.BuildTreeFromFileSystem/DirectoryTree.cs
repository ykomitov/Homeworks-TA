namespace _03.BuildTreeFromFileSystem
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public static class DirectoryTree
    {
        public static List<File> GetAllFilesInDirectory(string path)
        {
            var listOfFiles = new List<File>();

            try
            {
                listOfFiles = Directory.GetFiles(path)
                            .Select(p => new File()
                            {
                                Name = Path.GetFileName(p),
                                Size = new FileInfo(p).Length
                            })
                             .ToList();
            }
            catch (Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }

            return listOfFiles;
        }

        public static List<Folder> GetAllSubDirectoriesInDirectory(string path)
        {
            var listOfDirectories = new List<Folder>();
            try
            {
                listOfDirectories = Directory.GetDirectories(path)
                                          .Select(dir => new Folder()
                                          {
                                              Name = Path.GetFileName(dir),
                                              Files = GetAllFilesInDirectory(dir),
                                              ChildFolders = GetAllSubDirectoriesInDirectory(dir)
                                          })
                                          .ToList();
            }
            catch (Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }

            // Fill in the sum of file sizes for each directory
            foreach (var d in listOfDirectories)
            {
                d.SumOfFileSizes = GetSumOfFileSizes(d);
            }

            return listOfDirectories;
        }

        public static Folder BuildDirectoryTree(string path)
        {
            string folderName = Path.GetFileName(path);
            var listOfFilesInFolder = GetAllFilesInDirectory(path);
            var listOfSubdirectoriesInFolder = GetAllSubDirectoriesInDirectory(path);

            var tree = new Folder();
            tree.Name = folderName;
            tree.Files = listOfFilesInFolder;
            tree.ChildFolders = listOfSubdirectoriesInFolder;
            tree.SumOfFileSizes = GetSumOfFileSizes(tree);

            return tree;
        }

        private static long GetSumOfFileSizes(Folder folder)
        {
            long size = 0;

            // Get sum of files
            foreach (var file in folder.Files)
            {
                var fileSize = file.Size;
                size += fileSize;
            }

            // Get sum of files in subfolders (recursively)
            foreach (var subFolder in folder.ChildFolders)
            {
                size += GetSumOfFileSizes(subFolder);
            }

            return size;
        }
    }
}
