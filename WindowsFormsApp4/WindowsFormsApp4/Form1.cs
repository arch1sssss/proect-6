using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics graph = Graphics.FromImage(pictureBox1.Image);
            Pen maroonPen = new Pen(Brushes.Maroon);
            maroonPen.Width = 4;

            graph.DrawLine(maroonPen, 50, 50, 200, 200);
            graph.DrawEllipse(maroonPen, 300, 300, 40, 40);
            graph.DrawRectangle(maroonPen, 400, 50, 50, 50);
        }
        int x_start = 0;
        int y_start = 0;
        bool clicked = false;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(pictureBox1.Image);
            Pen maroonPen = new Pen(Brushes.Maroon);
            maroonPen.Width = 4;
            if (clicked == false)
            {
                x_start = e.X;
                y_start = e.Y;
                clicked = true;
                graph.DrawEllipse(maroonPen, x_start- 15, y_start- 15, 30, 30);
            }
            else
            {
                clicked = false;
                graph.DrawEllipse(maroonPen, x_start-15, y_start- 15, 30, 30);
                graph.DrawEllipse(maroonPen, e.X- 15, e.Y- 15, 30, 30);
                graph.DrawLine(maroonPen, x_start, y_start, e.X, e.Y);
            }


        }
    }
}
