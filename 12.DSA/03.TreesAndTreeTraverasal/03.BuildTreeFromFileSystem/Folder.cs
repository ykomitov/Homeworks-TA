namespace _03.BuildTreeFromFileSystem
{
    using System.Collections.Generic;

    public class Folder
    {
        public Folder()
        {
            this.ChildFolders = new List<Folder>();
            this.Files = new List<File>();
        }

        public string Name { get; set; }

        public List<File> Files { get; set; }

        public List<Folder> ChildFolders { get; set; }

        public long SumOfFileSizes { get; set; }
    }
}
