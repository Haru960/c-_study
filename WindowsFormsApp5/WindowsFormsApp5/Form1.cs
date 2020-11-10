using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            num1 = int.Parse(num_01.Value.ToString());
            num2 = int.Parse(num_02.Value.ToString());

            if(num1 == num2)
            {
                lb_Result1.Text = "값이 같습니다.";
            }
            else if(num1 > num2)
            {
                lb_Result1.Text = "첫 번째 수가 더 큽니다.";
            }
            else if(num2 > num1)
            {
                lb_Result1.Text = "두 번째 수가 더 큽니다.";
            }
        }

        private void btn_sel_Click(object sender, EventArgs e)
        {
            string str = cb_01.SelectedItem.ToString();

            lb_result2.Text = str + "요일 입니다.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
