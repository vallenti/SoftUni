using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TraverseDirectories
{
    public class File
    {
        public File(string name, long size = 0)
        {
            this.Name = name;
            this.Size = size;
        }

        public string Name { get; set; }
        public long Size { get; set; }
    }
}
