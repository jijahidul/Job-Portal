using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Portal
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Job_Seeker_SignUp js = new Job_Seeker_SignUp();
            js.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JobPubSign js = new JobPubSign();
            js.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.ShowDialog();
            this.Hide();
        }
    }
}
