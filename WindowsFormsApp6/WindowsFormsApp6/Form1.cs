using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_for_Click(object sender, EventArgs e)
        {
            string str = "for \n";
            StringBuilder sb = new StringBuilder();


            for (int i = 2; i <10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    str += string.Format("{0} x {1} = {2} \n", i, j, i * j);
                    sb.AppendLine(string.Format("{0} x {1} = {2}", i, j, i * j));
                }
            }
            rtb.Text = sb.ToString();
        }

        private void bnt_foreach_Click(object sender, EventArgs e)
        {
            string[] strArr = { "김OO", "이OO", "박OO", "최OO", "노OO", "유OO", "홍OO" };
            int i = 0;
            StringBuilder sb = new StringBuilder();



            foreach ( string val in strArr)
            {
                i++;
                sb.AppendLine(string.Format("{0} 학생은 {1}반 입니다.", val, i));
            }
            rtb.Text = sb.ToString();

        }

        private void btn_while_Click(object sender, EventArgs e)
        {
            rtb.Text = "";
            StringBuilder sb = new StringBuilder();
            int i = 10;

            while (i > 0)
            {
                sb.Append(string.Format("i : {0} \n", i--));
            }
            rtb.Text = sb.ToString();

        }

        private void btn_dowhile_Click(object sender, EventArgs e)
        {
            rtb.Text = "";
            StringBuilder sb = new StringBuilder();
            int i = 10;

            do
            {
                sb.Append(string.Format("i : {0} \n", i--));
            }
            while (i > 0);
            rtb.Text = sb.ToString();
        }
    }
}
