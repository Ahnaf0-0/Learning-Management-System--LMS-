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
    public partial class materials: Form
    {
        public materials()
        {
            InitializeComponent();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Student_Home h1 = new Student_Home();
            h1.Show();
            this.Hide();
        }

        private void qzbtn_Click(object sender, EventArgs e)
        {
            quiz q2 = new quiz();
            q2.Show();
            this.Hide();
        }

        private void notebtn_Click(object sender, EventArgs e)
        {
            notes n2 = new notes();
            n2.Show();
            this.Hide();
        }

        private void matbtn_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
