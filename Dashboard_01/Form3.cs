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
    public partial class notes: Form
    {
        public notes()
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
