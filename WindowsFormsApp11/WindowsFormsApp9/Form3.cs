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
    public partial class Form3 : Form
    {
        public int sum;
        public Form3()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int a_Num, b_Num;
            

            a_Num = int.Parse(tb_A.Text);
            b_Num = int.Parse(tb_B.Text);

            sum = a_Num + b_Num;
            Close();
        }
    }
}
