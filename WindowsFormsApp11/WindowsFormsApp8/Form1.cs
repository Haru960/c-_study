using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        int c = 0, cplus = 0, cshap = 0;
        int total = 0;
        float average = 0f;

        private void btn_chan_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(c.ToString());
                c = int.Parse(tb_C.Text);
                cplus = int.Parse(tb_Cplus.Text);
                cshap = int.Parse(tb_C_2.Text);
                total = c + cplus + cshap;
                average = total / 3.0f;

                listView1.SelectedItems[0].SubItems[0].Text = tb_C.Text;
                listView1.SelectedItems[0].SubItems[1].Text = tb_Cplus.Text;
                listView1.SelectedItems[0].SubItems[2].Text = tb_C_2.Text;
                listView1.SelectedItems[0].SubItems[3].Text = total.ToString();
                listView1.SelectedItems[0].SubItems[4].Text = average.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("입력창을 다 넣어주세요.");
            }
            finally
            {
                tb_C.Clear();
                tb_Cplus.Clear();
                tb_C_2.Clear();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int count = listView1.SelectedIndices.Count;
            if (listView1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("삭제할 위치를 선택해 주세요!");
                return;
            }
            if (count >= 2)
            {
                for (int i = 0; i < count; i++)
                {
                    listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                }
            }
            else
            {
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_input_Click(object sender, EventArgs e)
        {

            try
            {
                c = int.Parse(tb_C.Text);
                cplus = int.Parse(tb_Cplus.Text);
                cshap = int.Parse(tb_C_2.Text);
                total = c + cplus + cshap;
                average = total / 3.0f;
                listView1.Items.Add(new ListViewItem(new string[] {
                    c.ToString(), cplus.ToString(), cshap.ToString(),total.ToString(), average.ToString("f1") }));


            }
            catch (Exception ex)
            {
                MessageBox.Show("정수값만 입력하세요.");
            }
            tb_C.Clear();
            tb_Cplus.Clear();
            tb_C_2.Clear();
        }
    }
}
