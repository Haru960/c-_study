﻿using System;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = dateTimePicker1.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Long;
            //textBox1.Text = dateTimePicker1.Value.ToString();

            textBox1.Text = dateTimePicker1.Value.ToLongDateString();
        }
    }
}