using Job_Portal.Repository;
using Job_Portal.UserInterface.Admin;
using Job_Portal.UserInterface.Job_Seeker;
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
    public partial class Login : Form
    {
        public Login() 
        {
            InitializeComponent();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo c = new LoginInfo();


                int s = 0;
                s = c.checkLogin(userText.Text, passText.Text);
                if (s == 1)
                {
                    MessageBox.Show("Successfully Logged Into as Admin ");
                    Admin a = new Admin();
                    a.ShowDialog();

                }
                if (s == 2)
                {
                    MessageBox.Show("Logged Into as JOB PUBLISHER");
                   
                   
                }

                if (s == 3 )
                {
                    MessageBox.Show("Logged Into JOB SEEKER");

                    JobSeekerHome jsh = new JobSeekerHome();
                    jsh.ShowDialog();
                    jsh.StartPosition = FormStartPosition.CenterScreen;


                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("INVALID ID OR PASSWORD");

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            Sign_Up f2  = new Sign_Up();
            f2.ShowDialog();
            //f2.StartPosition = FormStartPosition.CenterScreen;




        }

        private void passText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    

