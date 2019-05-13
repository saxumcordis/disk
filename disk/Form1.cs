using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace disk
{
    public partial class Form1 : Form
    {

        private static readonly ExplorerService service = new ExplorerService();
        private readonly Regex numRegex = new Regex("^\\d+$");
        private StringFormat format = new StringFormat();
        public Form1()
        {
            InitializeComponent();
            setContextMenu(true);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((service.activeDisk == null) && (toolStripTextBox1.Text.Length != 0) && (numRegex.IsMatch(toolStripTextBox4.Text)) && isDiskExists())
            {
                flowLayoutPanel1.Controls.Add(viewFromDisk(service.createDisk(toolStripTextBox2.Text, Int32.Parse(toolStripTextBox4.Text))));
                toolStripTextBox2.Clear();
                toolStripTextBox4.Clear();
            }
        }
        private bool isDiskExists()
        {
            foreach (var disk in service.disks)
                if (toolStripTextBox1.Text == disk.name)
                    return false;
            return true;
        }

        private Control viewFromDisk(DiskFacade disk)
        {
            MouseEventHandler callback = (object sender, MouseEventArgs e) => openDisk(disk);
            var view = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Width = 50,
                Height = 100,
            };
            var pictureBox = new PictureBox()
            {
                Image = new Bitmap(".../disk.png"),
                Width = 50,
                Height = 32,
            };
            pictureBox.MouseClick += callback;
            view.Controls.Add(pictureBox);

            var label = new Label()
            {
                Text = disk.name,
                TextAlign = ContentAlignment.TopCenter,
                Padding = new Padding(0, 0, 66, 0)
            };
            label.MouseClick += callback;
            view.Controls.Add(label);

            view.MouseClick += callback;
            return view;
        }
        private Control viewFromFolder(string path)
        {
            MouseEventHandler callback = (object sender, MouseEventArgs e) => openFolder(path);
            var view = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Width = 50,
                Height = 100,
            };
            var pictureBox = new PictureBox()
            {
                Image = new Bitmap(".../folder.png"),
                Width = 50,
                Height = 32,
            };
            pictureBox.MouseClick += callback;
            view.Controls.Add(pictureBox);

            var label = new Label()
            {
                Text = path,
                TextAlign = ContentAlignment.TopCenter,
                Padding = new Padding(0, 0, 66, 0)
            };
            label.MouseClick += callback;
            view.Controls.Add(label);

            view.MouseClick += callback;
            return view;
        }
        private void openDisk(DiskFacade disk)
        {
            service.setActiveDisk(disk);
            flowLayoutPanel1.Controls.Clear();
            setContextMenu(false);
            foreach (var path in service.activeDisk.disk.viewDirectory(""))
            {
                flowLayoutPanel1.Controls.Add(viewFromFolder(path));
            }
        }
        private void openFolder(string path)
        {
            service.setActivePath(path);
            flowLayoutPanel1.Controls.Clear();
            setContextMenu(false);
            foreach (var postpath in service.activeDisk.disk.viewDirectory(path))
            {
                flowLayoutPanel1.Controls.Add(viewFromFolder(postpath));
            }
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var path = service.activePath + "/"+ toolStripTextBox6.Text;
            MessageBox.Show("sosat"+ service.activePath);
            MessageBox.Show(path + "   " + service.activePath);
            if (path.Length != 0)
            {
                flowLayoutPanel1.Controls.Add(viewFromFolder(path));
                service.activeDisk.disk.createPath(path);
            }
            toolStripTextBox6.Clear();
        }
    }
}
