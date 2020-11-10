using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
           

            tb_result.Text = plus().ToString();

        }

        private void btn_ma_Click(object sender, EventArgs e)
        {
            tb_result.Text = ma().ToString();
        }

        private void btn_rhq_Click(object sender, EventArgs e)
        {
            tb_result.Text = rhq().ToString();
        }

        private void btn_na_Click(object sender, EventArgs e)
        {
           

            tb_result.Text = na().ToString();
        }
        private float rhq()
        {
            float val1 = float.Parse(tb_val1.Text.ToString());
            float val2 = float.Parse(tb_val2.Text.ToString());
            float result = val1 * val2;

            return result;
        }
        private float ma()
        {

            float val1 = float.Parse(tb_val1.Text.ToString());
            float val2 = float.Parse(tb_val2.Text.ToString());
            float result = val1 - val2;

            return result;
        }


        private float plus()
        {
            float val1 = float.Parse(tb_val1.Text.ToString());
            float val2 = float.Parse(tb_val2.Text.ToString());
            float result = val1 + val2;

            return result;
        }

        private float na()
        {
            float val1 = float.Parse(tb_val1.Text.ToString());
            float val2 = float.Parse(tb_val2.Text.ToString());
            float result = val1 / val2;

            return result;
        }
    }

}
