using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetSize();
        }

        public double BoxWidth;
        public double BoxHeight;

        private class ArrayPoints
        {
            private int index = 0;
            private Point[] points;

            public ArrayPoints(int size)
            {
                if (size <= 0) { size = 2; }
                points = new Point[size];
            }

            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x, y);
                index++;
            }

            public void ResetPoints()
            {
                index = 0;
            }

            public int GetCountPoints()
            {
                return index;
            }

            public Point[] GetPoints()
            {
                return points;
            }
        }

        private bool isMouse = false;
        private ArrayPoints arrayPoints = new ArrayPoints(2);

        Bitmap map = new Bitmap(100, 100);
        Graphics graphics;

        Pen pen = new Pen(Color.Black, 3f);

        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            arrayPoints.ResetPoints();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse) { return; }

            arrayPoints.SetPoint(e.X, e.Y);
            if (arrayPoints.GetCountPoints() >= 2)
            {
                graphics.DrawLines(pen, arrayPoints.GetPoints());
                pictureBox1.Image = map;
                arrayPoints.SetPoint(e.X, e.Y);
            }
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(pictureBox1.BackColor);
            pictureBox1.Image = map;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                AddExtension = true,
                Multiselect = false,
                InitialDirectory = "C://Desktop",
                Title = "Select file to be upload",
                Filter = "JPG (.*jpg)|*.jpg|PNG (*.png)|*.png"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                map = new Bitmap(openFileDialog.FileName);
                graphics = Graphics.FromImage(map);
                pictureBox1.Image = map;
                pictureBox1.Width = map.Width;
                pictureBox1.Height = map.Height;
            }
            openFileDialog.Dispose();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JPG (.*jpg )|*.jpg|PNG (*.png)|*.png",
                Title = "Save picture as...",
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file = (FileStream)saveFileDialog.OpenFile();

                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        pictureBox1.Image = null;
                        pictureBox1.Image = map;
                        pictureBox1.Image.Save(file, ImageFormat.Jpeg);
                        break;

                    case 2:
                        pictureBox1.Image.Save(file, ImageFormat.Png);
                        break;
                }
                file.Close();
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void Btn_ZoomUp_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Size size = new Size((int)Math.Round(pictureBox1.Image.Width * 1.05), (int)Math.Round(pictureBox1.Image.Height * 1.05));
                pictureBox1.Image = new Bitmap(map, size);
                pictureBox1.Height = pictureBox1.Image.Height;
                pictureBox1.Width = pictureBox1.Image.Width;
                map = (Bitmap)pictureBox1.Image;
                graphics = Graphics.FromImage(map);
                pictureBox1.Image = map;
            }
        }

        private void Btn_ZoomDown_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Size size = new Size((int)Math.Round(pictureBox1.Image.Width * 0.9), (int)Math.Round(pictureBox1.Image.Height * 0.9));
                pictureBox1.Image = new Bitmap(map, size);
                pictureBox1.Height = pictureBox1.Image.Height;
                pictureBox1.Width = pictureBox1.Image.Width;
                map = (Bitmap)pictureBox1.Image;
                graphics = Graphics.FromImage(map);
                pictureBox1.Image = map;
            }
        }
    }
}