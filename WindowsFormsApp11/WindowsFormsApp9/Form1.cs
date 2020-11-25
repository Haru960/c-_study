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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            DialogResult result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("OK 버튼 눌림");
            }
            else if (result == DialogResult.Yes)
            {
                MessageBox.Show("Yes 버튼 눌림");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("CANCEL 버튼 눌림");
            }
            dlg.Dispose();
        }

        private void 열기2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 dlg = new Form3();
            dlg.ShowDialog();
            


            MessageBox.Show("결과 : " + dlg.sum);

            dlg.Dispose();
        }
    }
}
