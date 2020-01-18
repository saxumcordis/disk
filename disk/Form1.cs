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
            if ((toolStripTextBox2.Text != service.activePath) && (toolStripTextBox2.Text.Length != 0) && (toolStripTextBox4.Text.Length != 0)
            && (numRegex.IsMatch(toolStripTextBox4.Text)) && isDiskExists())
            {
                flowLayoutPanel1.Controls.Add(viewFromDisk(service.createDisk(toolStripTextBox2.Text, Int32.Parse(toolStripTextBox4.Text))));
                toolStripTextBox2.Clear();
                toolStripTextBox4.Clear();
            }
        }
        private bool isDiskExists()
        {
            foreach (var disk in service.disks)
                if (toolStripTextBox2.Text == disk.name)
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
        private Control viewFromFile(File file)
        {
            MouseEventHandler callback = (object sender, MouseEventArgs e) => fileActions(file);
            var view = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                Width = 50,
                Height = 100,
            };

            var pictureBox = new PictureBox()
            {
                Image = new Bitmap(".../file.png"),
                Width = 50,
                Height = 32
            };
            pictureBox.MouseClick += callback;
            view.Controls.Add(pictureBox);

            var label = new Label()
            {
                Text = file.getPath(),
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
            pathField.Text = service.activePath;
            flowLayoutPanel1.Controls.Clear();
            setContextMenu(false);
            service.frontHistory.Clear();
            service.setActivePath(null);
            service.activeDisk.disk.viewDirectory("/").ForEach(
            path => flowLayoutPanel1.Controls.Add(viewFromFolder("/" + path))
            );
        }
        private void openFolder(string path)
        {
            service.setActivePath(path);
            pathField.Text = service.activePath;
            setContextMenu(false);
            flowLayoutPanel1.Controls.Clear();
            pathField.Text = service.activePath;

            foreach (var postpath in service.activeDisk.disk.viewDirectory(service.activePath))
            {
                if (postpath.Contains("dir"))
                    flowLayoutPanel1.Controls.Add(viewFromFolder(postpath));
                else if (postpath.Contains("file"))
                {
                    MessageBox.Show(postpath);
                    flowLayoutPanel1.Controls.Add(viewFromFile(service.activeDisk.disk.getFile(postpath)));
                }
            }         
        }
        private void fileActions(File file)
        {
            DialogResult dialogResult = MessageBox.Show("Путь файла: " + file.path
                + "\r\nИндекс файла: " + service.activeDisk.disk.getIndexOfFile(file)
                + "\n\n\nДля удаления файла нажмите 'ДА'"
                , "FileAction", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                service.activeDisk.disk.delete(file.path);
                service.activeDisk.disk.deleteFile(file.path);
                flowLayoutPanel1.Controls.Clear();
                foreach (var postpath in service.activeDisk.disk.viewDirectory(service.activePath))
                {
                    if (postpath.Contains("dir"))
                        flowLayoutPanel1.Controls.Add(viewFromFolder(postpath));
                    else if (postpath.Contains("file"))
                    {
                        MessageBox.Show(postpath);
                        flowLayoutPanel1.Controls.Add(viewFromFile(service.activeDisk.disk.getFile(postpath)));
                    }
                }
            }
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var path = service.activePath + toolStripTextBox6.Text+".dir";


            if (path.Length != 0)
            {
                service.activeDisk.disk.createPath(path);
                flowLayoutPanel1.Controls.Add(viewFromFolder(path));
                MessageBox.Show(path);
            }

            toolStripTextBox6.Clear();
        }
        private void goBackButton_Click(object sender, EventArgs e)
        {
            if (service.backHistory.Count < 2)
            {
                setContextMenu(true);
                flowLayoutPanel1.Controls.Clear();
                service.backHistory.Clear();
                pathField.Clear();

                foreach (var disk in service.disks)
                    flowLayoutPanel1.Controls.Add(viewFromDisk(disk));
                service.frontHistory.Push("");
            }
            else
                openFolder(service.backHistory.Peek());
        }
        private void goForwardButton_Click(object sender, EventArgs e)
        {
            if (service.frontHistory.Count != 0)
            {
                openFolder(service.frontHistory.Peek());
            }
        }
        private void создатьФайлMenuItem3_Click(object sender, EventArgs e)
        {
            if (numRegex.IsMatch(toolStripTextBox10.Text))
            {
                var file = new File(service.activePath + toolStripTextBox8.Text+".file", Encoding.ASCII.GetBytes(toolStripTextBox10.Text));
                service.activeDisk.disk.write(file);
                flowLayoutPanel1.Controls.Add(viewFromFile(file));
                toolStripTextBox8.Clear();
                toolStripTextBox10.Clear();
            }
        }
    }
}
