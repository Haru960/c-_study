using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Rectangle[] rectangle;
        public Form1()
        {
            InitializeComponent();
            rectangle = new Rectangle[50];
            SetClientSizeCore(Properties.Resources.Programming_Windows.Width,
                Properties.Resources.Programming_Windows.Height);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bitmap = Properties.Resources.Programming_Windows;
            e.Graphics.DrawImage(bitmap, 0, 0);
            for (int i = 0; i < rectangle.Length; i++)
            {
                e.Graphics.DrawRectangle(Pens.Black, rectangle[i]);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("종료하겠습니까?", "종료창", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("완전종료");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SetClientSizeCore(Properties.Resources.Programming_Windows.Width,
                Properties.Resources.Programming_Windows.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Hide();
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            MessageBox.Show("layout");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < rectangle.Length; i++)
            {
                rectangle[i].X = rand.Next(200);
                rectangle[i].Y = rand.Next(200);
                rectangle[i].Width = 60;
                rectangle[i].Height = 60;
            }
            Invalidate();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MENU 열기!!!");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void 열기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("COUNTEXTMENU 열기!");
        }
    }
}
