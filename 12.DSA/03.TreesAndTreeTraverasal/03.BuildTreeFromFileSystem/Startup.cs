/* Define classes File { string name, int size } and Folder { string name, File[] files, Folder[] childFolders } and using them build a tree keeping all files and folders on the hard drive starting from C:\WINDOWS. Implement a method that calculates the sum of the file sizes in given subtree of the tree and test it accordingly. Use recursive DFS traversal. */

namespace _03.BuildTreeFromFileSystem
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var rootDir = "../../../02.DirectoryTraversal/testDir";
            ////var rootDir = "C://WINDOWS";

            var rootDirTree = DirectoryTree.BuildDirectoryTree(rootDir);

            Console.WriteLine("Total file size in direcotry {0} is {1}", rootDirTree.Name, rootDirTree.SumOfFileSizes);
            Console.WriteLine("Total file size is subdirectories:\r\n");

            foreach (var subDir in rootDirTree.ChildFolders)
            {
                Console.WriteLine("Folder name: {0}", subDir.Name);
                Console.WriteLine("Size: {0} KB\r\n", subDir.SumOfFileSizes);
            }
        }
    }
}
