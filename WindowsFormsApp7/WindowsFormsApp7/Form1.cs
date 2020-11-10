using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        string strMousePos;
        List<Point> ListPoint = new List<Point>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("버튼 눌림");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("폼 클릭");

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("마우스 클릭");

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Font f = new Font("batang", 30);
            e.Graphics.DrawString(strMousePos, f, Brushes.Black, 10, 10);

            if(ListPoint.Count == 3)
            {
                e.Graphics.DrawLine(Pens.Black, ListPoint[0], ListPoint[1]);
                e.Graphics.DrawLine(Pens.Black, ListPoint[1], ListPoint[2]);
                e.Graphics.DrawLine(Pens.Black, ListPoint[2], ListPoint[0]);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point pt = new Point(e.X, e.Y);
                if (ListPoint.Count == 3)
                {
                    ListPoint.Clear();
                }
                ListPoint.Add(pt);
            }
            strMousePos = "" + e.Location;
            Invalidate();
        }
    }
}
