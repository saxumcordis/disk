namespace disk
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.goBackButton = new System.Windows.Forms.Button();
            this.goForwardButton = new System.Windows.Forms.Button();
            this.pathField = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьФайлStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox7 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox8 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox9 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox10 = new System.Windows.Forms.ToolStripTextBox();
            this.создатьФайлMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьДискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.создатьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox6 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(13, 13);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(19, 23);
            this.goBackButton.TabIndex = 0;
            this.goBackButton.Text = "←";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // goForwardButton
            // 
            this.goForwardButton.Location = new System.Drawing.Point(38, 13);
            this.goForwardButton.Name = "goForwardButton";
            this.goForwardButton.Size = new System.Drawing.Size(19, 23);
            this.goForwardButton.TabIndex = 1;
            this.goForwardButton.Text = "→";
            this.goForwardButton.UseVisualStyleBackColor = true;
            this.goForwardButton.Click += new System.EventHandler(this.goForwardButton_Click);
            // 
            // pathField
            // 
            this.pathField.Location = new System.Drawing.Point(64, 15);
            this.pathField.Name = "pathField";
            this.pathField.Size = new System.Drawing.Size(703, 20);
            this.pathField.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.ContextMenuStrip = this.contextMenuStrip1;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 54);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(784, 387);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьФайлStripMenuItem4});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // создатьФайлStripMenuItem4
            // 
            this.создатьФайлStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox7,
            this.toolStripTextBox8,
            this.toolStripSeparator6,
            this.toolStripTextBox9,
            this.toolStripTextBox10,
            this.создатьФайлMenuItem3});
            this.создатьФайлStripMenuItem4.Name = "создатьФайлStripMenuItem4";
            this.создатьФайлStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.создатьФайлStripMenuItem4.Text = "Создать Файл";
            // 
            // toolStripTextBox7
            // 
            this.toolStripTextBox7.Enabled = false;
            this.toolStripTextBox7.Name = "toolStripTextBox7";
            this.toolStripTextBox7.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox7.Text = "Название";
            // 
            // toolStripTextBox8
            // 
            this.toolStripTextBox8.Name = "toolStripTextBox8";
            this.toolStripTextBox8.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripTextBox9
            // 
            this.toolStripTextBox9.Enabled = false;
            this.toolStripTextBox9.Name = "toolStripTextBox9";
            this.toolStripTextBox9.ReadOnly = true;
            this.toolStripTextBox9.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox9.Text = "Размер";
            // 
            // toolStripTextBox10
            // 
            this.toolStripTextBox10.Name = "toolStripTextBox10";
            this.toolStripTextBox10.Size = new System.Drawing.Size(100, 23);
            // 
            // создатьФайлMenuItem3
            // 
            this.создатьФайлMenuItem3.Name = "создатьФайлMenuItem3";
            this.создатьФайлMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.создатьФайлMenuItem3.Text = "Создать";
            this.создатьФайлMenuItem3.Click += new System.EventHandler(this.создатьФайлMenuItem3_Click);
            // 
            // создатьДискToolStripMenuItem
            // 
            this.создатьДискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.toolStripSeparator1,
            this.toolStripTextBox3,
            this.toolStripTextBox4,
            this.toolStripSeparator5,
            this.toolStripMenuItem1});
            this.создатьДискToolStripMenuItem.Name = "создатьДискToolStripMenuItem";
            this.создатьДискToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.создатьДискToolStripMenuItem.Text = "Создать диск";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Название";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Enabled = false;
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.ReadOnly = true;
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox3.Text = "Размер";
            // 
            // toolStripTextBox4
            // 
            this.toolStripTextBox4.Name = "toolStripTextBox4";
            this.toolStripTextBox4.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem1.Text = "Создать";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // создатьПапкуToolStripMenuItem
            // 
            this.создатьПапкуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox5,
            this.toolStripTextBox6,
            this.toolStripSeparator2,
            this.toolStripMenuItem2});
            this.создатьПапкуToolStripMenuItem.Name = "создатьПапкуToolStripMenuItem";
            this.создатьПапкуToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.создатьПапкуToolStripMenuItem.Text = "Создать папку";
            // 
            // toolStripTextBox5
            // 
            this.toolStripTextBox5.Enabled = false;
            this.toolStripTextBox5.Name = "toolStripTextBox5";
            this.toolStripTextBox5.ReadOnly = true;
            this.toolStripTextBox5.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox5.Text = "Название";
            // 
            // toolStripTextBox6
            // 
            this.toolStripTextBox6.Name = "toolStripTextBox6";
            this.toolStripTextBox6.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem2.Text = "Создать";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.pathField);
            this.Controls.Add(this.goForwardButton);
            this.MaximumSize = new System.Drawing.Size(800, 480);
            this.MinimumSize = new System.Drawing.Size(800, 480);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button goForwardButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;      
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьДискToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem создатьПапкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private void setContextMenu(bool state)
        {
            contextMenuStrip1.Items.Clear();
            if (state) setDiskContextMenu();
            else setDirContextMenu();
        }
        private void setDiskContextMenu()
        {
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьДискToolStripMenuItem});
        }
        private void setDirContextMenu()
        {
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьПапкуToolStripMenuItem, this.создатьФайлStripMenuItem4});
        }

        public System.Windows.Forms.TextBox pathField;
        private System.Windows.Forms.ToolStripMenuItem создатьФайлStripMenuItem4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox9;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox10;
        private System.Windows.Forms.ToolStripMenuItem создатьФайлMenuItem3;
    }
}

