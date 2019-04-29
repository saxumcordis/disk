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
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((toolStripTextBox1.Text.Length != 0) & (numRegex.IsMatch(toolStripTextBox2.Text)) & (ifExistInDisks()))
            {
                flowLayoutPanel1.Controls.Add(viewFromDisk(service.createDisk(toolStripTextBox1.Text, Int32.Parse(toolStripTextBox2.Text))));
                toolStripTextBox1.Clear();
                toolStripTextBox2.Clear();
            }
        }
        private bool ifExistInDisks()
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

        private void openDisk(DiskFacade disk)
        {
            flowLayoutPanel1.Controls.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
       
    
        
    }
}
