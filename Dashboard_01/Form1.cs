using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_01
{
    public partial class Student_Home: Form
    {
        public Student_Home()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            //homebtn.FlatStyle = FlatStyle.Flat;
            //homebtn.FlatAppearance.BorderSize = 0;
            //homebtn.BackColor = Color.Transparent;
            //homebtn.ForeColor = Color.White;
            //homebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void qzbtn_Click(object sender, EventArgs e)
        {

        }

        private void qzbtn_Click_1(object sender, EventArgs e)
        {
            quiz f2 = new quiz();
            f2.Show();
            this.Hide();
        }

        private void notebtn_Click(object sender, EventArgs e)
        {
            notes n1 = new notes();
            n1.Show();
            this.Hide();
        }

        private void matbtn_Click(object sender, EventArgs e)
        {
            materials m1 = new materials();
            m1.Show();
            this.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
