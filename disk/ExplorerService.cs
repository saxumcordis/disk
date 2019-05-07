using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disk
{
    class ExplorerService
    {
        public DiskFacade activeDisk { get; set; }
        public string activePath { get; set; }
        public List<DiskFacade> disks = new List<DiskFacade>();
        public DiskFacade createDisk(string name, int size)
        {
            var disk = new DiskFacade(name, size);
            disks.Add(disk);
            return disk;
        }
    }
}
