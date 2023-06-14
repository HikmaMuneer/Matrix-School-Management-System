using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";
        }

        //Exit Application
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //User Login
        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_username.Text == "" ||  txt_password.Text == "")
            {
                MessageBox.Show("Enter username and password!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if(txt_username.Text == "Admin" && txt_password.Text =="Password")
            {
                MainMenu Obj = new MainMenu();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txt_username.Text = "";
                txt_password.Text = "";
            }
        }
    }
}
