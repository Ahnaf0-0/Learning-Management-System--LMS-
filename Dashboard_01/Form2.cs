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
    public partial class quiz: Form
    {
        public quiz()
        {
            InitializeComponent();
        }

        private void homebtn_Click_1(object sender, EventArgs e)
        {
            Student_Home s1 = new Student_Home();
            s1.Show();
            this.Hide();
        }

        private void qzbtn_Click(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
