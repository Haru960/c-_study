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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = " ";
            str = tb_Text_val.Text;

            lb_Contain_val.Text = str.Contains("babo").ToString();
            lb_Equals_val.Text = str.Equals("asd").ToString();
            lb_Length_val.Text = str.Length.ToString();
            lb_Replace_val.Text = str.Replace("T", "3");
            if (str.Contains("_"))
            {
                string[] split1 = str.Split('_');
                lb_Split_01.Text = split1[0];
                lb_Split_02.Text = split1[1];
            }
            else
            {
                lb_Split_01.Text = "언더바('_')";
                lb_Split_02.Text = "없음";
            }
            if(str.Length > 7)
            {
                lb_Substring_val.Text = str.Substring(3, 5);
            }
            else
            {
                lb_Substring_val.Text = "문자열 길이가 짧아요!";
            }
            lb_ToLower_val.Text = str.ToLower();
            lb_Upper_val.Text = str.ToUpper();
            lb_Trim_val.Text = str.Trim();
            this.Text = "실행!!!";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lb_Equals_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb_Contain_val.Text = "-";
            lb_Equals_val.Text = "-";
            lb_Length_val.Text = "-";
            lb_Replace_val.Text = "-";
            lb_Split_01.Text = "-";
            lb_Split_02.Text = "-";
            lb_Substring_val.Text = "-";
            lb_ToLower_val.Text = "-";
            lb_Upper_val.Text = "-";
            lb_Trim_val.Text = "-";
            this.Text = "초기화!!";
        }
    }
}
