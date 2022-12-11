namespace SimplePaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gjyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_ZoomDown = new System.Windows.Forms.Button();
            this.Btn_ZoomUp = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel5 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.gjyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gjyToolStripMenuItem
            // 
            this.gjyToolStripMenuItem.BackgroundImage = global::SimplePaint.Properties.Resources.save;
            this.gjyToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gjyToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.gjyToolStripMenuItem.Name = "gjyToolStripMenuItem";
            this.gjyToolStripMenuItem.Size = new System.Drawing.Size(25, 23);
            this.gjyToolStripMenuItem.Text = "  ";
            this.gjyToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.BtnClear);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Btn_ZoomDown);
            this.panel4.Controls.Add(this.Btn_ZoomUp);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(478, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 100);
            this.panel4.TabIndex = 3;
            this.panel4.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // Btn_ZoomDown
            // 
            this.Btn_ZoomDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_ZoomDown.BackgroundImage")));
            this.Btn_ZoomDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ZoomDown.Location = new System.Drawing.Point(4, 52);
            this.Btn_ZoomDown.Name = "Btn_ZoomDown";
            this.Btn_ZoomDown.Size = new System.Drawing.Size(43, 43);
            this.Btn_ZoomDown.TabIndex = 1;
            this.Btn_ZoomDown.UseVisualStyleBackColor = true;
            this.Btn_ZoomDown.Click += new System.EventHandler(this.Btn_ZoomDown_Click);
            // 
            // Btn_ZoomUp
            // 
            this.Btn_ZoomUp.BackgroundImage = global::SimplePaint.Properties.Resources.ZoomUp;
            this.Btn_ZoomUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ZoomUp.Location = new System.Drawing.Point(4, 3);
            this.Btn_ZoomUp.Name = "Btn_ZoomUp";
            this.Btn_ZoomUp.Size = new System.Drawing.Size(43, 43);
            this.Btn_ZoomUp.TabIndex = 0;
            this.Btn_ZoomUp.UseVisualStyleBackColor = true;
            this.Btn_ZoomUp.Click += new System.EventHandler(this.Btn_ZoomUp_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClear.Location = new System.Drawing.Point(423, 0);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(55, 100);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(228, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 100);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size of pen:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 46);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(188, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button_1);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 100);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(184, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(38, 38);
            this.button6.TabIndex = 12;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(184, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 38);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.BlueViolet;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(140, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(38, 38);
            this.button7.TabIndex = 11;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(52, 47);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(38, 38);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.Black;
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_1.Location = new System.Drawing.Point(8, 3);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(38, 38);
            this.button_1.TabIndex = 3;
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Blue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(96, 47);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(38, 38);
            this.button8.TabIndex = 10;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(52, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 38);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(96, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 38);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Green;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Location = new System.Drawing.Point(8, 47);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(38, 38);
            this.button10.TabIndex = 8;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Orange;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(140, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 38);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1366, 768);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 127);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(884, 384);
            this.panel5.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Form1";
            this.Text = "Simple Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem gjyToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button BtnClear;
        private Panel panel3;
        private Label label1;
        private TrackBar trackBar1;
        private Panel panel2;
        private Button button6;
        private Button button5;
        private Button button7;
        private Button button9;
        private Button button_1;
        private Button button8;
        private Button button2;
        private Button button3;
        private Button button10;
        private Button button4;
        private Panel panel4;
        private ColorDialog colorDialog1;
        private Button Btn_ZoomDown;
        private Button Btn_ZoomUp;
        private Panel panel5;
        private ContextMenuStrip contextMenuStrip1;
    }
}