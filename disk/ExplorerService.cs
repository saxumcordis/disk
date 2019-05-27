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
        public Stack<string> backHistory = new Stack<string>();
        public Stack<string> frontHistory = new Stack<string>();
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
            backHistory.Push(disk.name + ":/");
        }

        public void setActivePath(string path)
        {
            if (path != activePath)
            {

                if ((backHistory.Count > 0) && (path == backHistory.Peek()))
                {
                    frontHistory.Push(activePath);
                    activePath = backHistory.Pop();
                }
                else if ((frontHistory.Count > 0) && (path == frontHistory.Peek()))
                {
                    backHistory.Push(activePath);
                    activePath = frontHistory.Pop();
                }
                else
                {
                    backHistory.Push(activePath);
                    activePath = activePath + path;
                }
            }
        }
    }
}
