﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frame_2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                MessageBox.Show("Correct Password");
                Form1 form2 = new Form1();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
