using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TraverseDirectories
{
    public class Folder
    {
        public Folder(string name)
        {
            this.Name = name;
            this.Files = new List<File>();
            this.ChildFolders = new List<Folder>();
        }

        public string Name { get; set; }
        public ICollection<File> Files { get; set; }
        public ICollection<Folder> ChildFolders { get; set; }
    }
}
