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
        RadioButton SelectedRadio;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strResult = "체크 1: " + checkBox1.CheckState +
                "\n체크 2: " + checkBox2.CheckState +
                "\n체크 3: " + checkBox3.CheckState;
            MessageBox.Show(strResult);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("radio 1 선택");
            else if (radioButton2.Checked)
                MessageBox.Show("radio 2 선택");
            else if (radioButton3.Checked)
                MessageBox.Show("radio 3 선택");
            else if (radioButton4.Checked)
                MessageBox.Show("radio 4 선택");
            else if (radioButton5.Checked)
                MessageBox.Show("radio 5 선택");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton6 == SelectedRadio)
                MessageBox.Show("radio 6 선택");
            else if (radioButton7 == SelectedRadio)
                MessageBox.Show("radio 7 선택");
            else if (radioButton8 == SelectedRadio)
                MessageBox.Show("radio 8 선택");
            else if (radioButton9 == SelectedRadio)
                MessageBox.Show("radio 9 선택");
            else if (radioButton10 == SelectedRadio)
                MessageBox.Show("radio 10 선택");
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            SelectedRadio = (RadioButton)sender;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            SelectedRadio = (RadioButton)sender;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            SelectedRadio = (RadioButton)sender;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            SelectedRadio = (RadioButton)sender;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            SelectedRadio = (RadioButton)sender;
        }
    }
}
