using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
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

        private void lb_short_val_Click(object sender, EventArgs e)
        {

        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    lb_short_val.Text = double.Parse(txt_input.Text).ToString();
            //    lb_int_val.Text = short.Parse(txt_input.Text).ToString();
            //    lb_double_val.Text = int.Parse(txt_input.Text).ToString();
            //    lb_Exception_val.Text = "-";
            //}
            //catch (Exception ex)
            //{
            //    lb_short_val.Text = "-";
            //    lb_int_val.Text = "-";
            //    lb_double_val.Text = "-";
            //    lb_Exception_val.Text = ex.ToString();
            //}
            short shnum2 = 0;
            int innum2 = 0;
            double dnum2 = 0;
            if(short.TryParse(txt_input.Text, out shnum2))
            {
                lb_short_val.Text = shnum2.ToString();
                lb_int_val.Text = "-";
                lb_double_val.Text = "-";
            }
            else if(int.TryParse(txt_input.Text, out innum2))
            {
                lb_int_val.Text = innum2.ToString();
                lb_double_val.Text = "-";
                lb_short_val.Text = "-";
            }
            else if(double.TryParse(txt_input.Text, out dnum2))
            {
                lb_double_val.Text = dnum2.ToString();
                lb_short_val.Text = "-";
                lb_int_val.Text = "-";
            }
            else
            {
                lb_Exception_val.Text = "변환 불가능";
                lb_short_val.Text = "-";
                lb_int_val.Text = "-";
                lb_double_val.Text = "-";
            }
        }

        private void btn_short_Click(object sender, EventArgs e)
        {
            try
            {
                lb_short_val.Text = short.Parse(txt_input.Text).ToString();
                lb_Exception_val.Text = "-";
            }
            catch(Exception ex)
            {
                lb_short_val.Text = "-";
                lb_Exception_val.Text = ex.ToString();
            }
        }

        private void btn_int_Click(object sender, EventArgs e)
        {
            try
            {
                lb_int_val.Text = int.Parse(txt_input.Text).ToString();
                lb_Exception_val.Text = "-";
            }
            catch (Exception ex)
            {
                lb_int_val.Text = "-";
                lb_Exception_val.Text = ex.ToString();
            }
        }

        private void btn_double_Click(object sender, EventArgs e)
        {
            try
            {
                lb_double_val.Text = double.Parse(txt_input.Text).ToString();
                lb_Exception_val.Text = "-";
            }
            catch (Exception ex)
            {
                lb_double_val.Text = "-";
                lb_Exception_val.Text = ex.ToString();
            }
        }
    }
}
