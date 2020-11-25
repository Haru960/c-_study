using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        int Number;
        public string Message;
        int red, green, blue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();

            dlg.Owner = this;
            Message = textBox1.Text;
            dlg.ShowDialog();
            textBox1.Clear();
            dlg.Dispose();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream mySteam;
            openFileDialog1.Filter = "데이터(*.dat)|.dat|텍스트(*.txt)|*.txt";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((mySteam = openFileDialog1.OpenFile()) != null)
                {
                    using (BinaryReader br = new BinaryReader(mySteam))
                    {
                        Number = br.ReadInt32();
                        Message = br.ReadString();
                        Invalidate();
                    }
                }
            }
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Number = 12;
            string Message = "Hello World!";
            Stream myStream;
            saveFileDialog1.DefaultExt = "dat";
            saveFileDialog1.Filter = "데이터(*.dat)|.dat|텍스트(*.txt)|*.txt";//저장 하는 확장자 형태 제한

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    using (BinaryWriter bw = new BinaryWriter(myStream))
                    {
                        bw.Write(Number);
                        bw.Write(Message);
                    }
                }
                
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string str = "Red: " + red + "    Green: " + green + "    Blue: " + blue;
            e.Graphics.DrawString(str, Font, Brushes.Black, 10, 120);
            e.Graphics.DrawString(Number.ToString(), Font, Brushes.Black, 10, 30);
            e.Graphics.DrawString(Message, Font, Brushes.Black, 10, 50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color1 = colorDialog1.Color;
                red = color1.R;
                green = color1.G;
                blue = color1.B;
                Invalidate();

            }
        }
    }
}
