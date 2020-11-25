using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 폼1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 mdiChildForm1 = new Form2();
            mdiChildForm1.MdiParent = this;
            mdiChildForm1.Show();
        }

        private void 폼2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 폼3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 mdiChildForm3 = new Form4();
            mdiChildForm3.MdiParent = this;
            mdiChildForm3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
