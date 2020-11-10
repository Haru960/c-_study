using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string strMessage;
        int x = 10;
        int y = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int ran = rand.Next(1, 8);
            btn_1.Text = ran + "";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Red, 10, 10, 200, 10);
            e.Graphics.DrawEllipse(Pens.Black, 10, 20, 100, 100);
            e.Graphics.DrawRectangle(Pens.Pink, 130, 20, 100, 100);
            e.Graphics.DrawString(strMessage, Font, Brushes.Red, x, y);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true)
            {
                MessageBox.Show("KeyDown");
            }
            else if(e.KeyCode == Keys.A && e.Shift | e.Control)
            {
                MessageBox.Show("A + shift + ctrl");
            }
            else if(e.KeyCode == Keys.Up)
            {
                y -= 5;
                Invalidate();
            }
            else if (e.KeyCode == Keys.Down)
            {
                y += 5;
                Invalidate();
            }
            else if (e.KeyCode == Keys.Left)
            {
                x -= 5;
                Invalidate();
            }
            else if (e.KeyCode == Keys.Right)
            {
                x += 5;
                Invalidate();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            strMessage += e.KeyChar;
            Invalidate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
