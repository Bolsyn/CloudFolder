using System;
using System.Collections.Generic;
using System.Text;

namespace CloudFolder.Model
{
    public class Folder : Entity
    {
        public string Name { get; set; }
        public ICollection<Folder> Folders { get; set; }
        public ICollection<Folder> Files { get; set; }
    }
}
