using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        //Point[] ptCircle = new Point[10];
        List<Point> ptCircle = new List<Point>();
        int nCount; //기본 초기화 0
        int X = 20;
        int Y = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            ptCircle.Add(pt);
            Graphics g = CreateGraphics();
            for (int i = 0; i < ptCircle.Count; i++)
            {
                g.DrawEllipse(Pens.Black, ptCircle[i].X - 10, ptCircle[i].Y - 10, X, Y);
            }
            nCount++;
            g.Dispose();
        }
    }
}
