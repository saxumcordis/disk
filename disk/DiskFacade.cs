using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disk
{
    class DiskFacade
    {
        public string name { get; set; }
        public int size { get; }
        public Disk disk { get; }
        public DiskFacade(string name, int size)
        {
            this.name = name;
            this.disk = new Disk(size);
        }
    }
}
