using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            Color mColor = Color.FromArgb(255, 0, 0);
            SolidBrush myBrush = new SolidBrush(Color.Blue);
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.Plaid, Color.Red, Color.Black);
            g.FillEllipse(hatchBrush, 100, 100, 100, 100);
            Pen newPen = new Pen(mColor, 5.0f);
            newPen.DashStyle = DashStyle.Dot;
            string str = "Alpha: " + Color.Blue.A + " Red : " + Color.Blue.R + "Greem :  " + Color.Blue.G + "Blue : " + Color.Blue;
            g.DrawLine(newPen, 10, 30, 100, 30);
            newPen.DashStyle = DashStyle.DashDotDot;
            g.DrawLine(newPen, 10, 70, 100, 70);
            g.DrawLine(Pens.Blue, 10, 50, 100, 50);
            g.DrawString(str, Font, Brushes.Blue, 10, 10);

            g.Dispose();
        }
    }
}
