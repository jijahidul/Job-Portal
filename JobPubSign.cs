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
    public partial class JobPubSign : Form
    {
        public JobPubSign()
        {
            InitializeComponent();
        }

        private void JobPubSign_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up s = new Sign_Up();
            s.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
