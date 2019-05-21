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
        public string activePath { get; set; } = "/";
        public Stack<string> history = new Stack<string>();
        public List<DiskFacade> disks = new List<DiskFacade>();
        public Form1 form = new Form1();

        public DiskFacade createDisk(string name, int size)
        {
            var disk = new DiskFacade(name, size);
            disks.Add(disk);
            return disk;
        }

        public void setActiveDisk(DiskFacade disk)
        {
            activeDisk = disk;
            history.Push(disk.name + ":/");
        }

        public void setActivePath(string path)
        {
            activePath = path.StartsWith("/") ? path : ("/" + path);
            history.Push(activeDisk + ":/" );
        }
    }
}
