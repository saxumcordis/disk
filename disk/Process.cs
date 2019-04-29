using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace disk
{
    class Process: Form1
    {
        public string name { get; set; }
        public int size { get; set; }
        public Process() { }
        public List<Process> disks = new List<Process>();
        private static readonly GraphicElement graphic = new GraphicElement();
        public Process(string name, Disk disk)
        {
            this.name = name;
        }

        public PictureBox createDiskPicture(string name, int counter)
        {
            var pictureBox = new PictureBox();
            pictureBox.Size = new Size(32,32);
            pictureBox.Location = new Point(50 + (int)(counter*2) - (Width-100)*(int)Math.Floor((decimal)2.5 * counter / Width), 
                60 *(1+ (int)Math.Floor((decimal)2.5*counter/Width)));
            pictureBox.Image = new Bitmap(".../disk.png");
           // pictureBox.MouseClick += new MouseEventHandler(() = > createDiskPicture());
            graphic.GraphicElements.Add(new GraphicElement(pictureBox.Size, pictureBox.Location, pictureBox.Image));
            return pictureBox;
        }
       public void drawAllDisks() { 
}
    }
}
