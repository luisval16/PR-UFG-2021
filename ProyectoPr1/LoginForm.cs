using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPr1
{
    public partial class LoginForm : Form
    {

        private String username = "admin";
        private String password = "admin123";

        public LoginForm()
        {
            InitializeComponent();
            this.txtEmail.Text = username;
            this.txtPassword.Text = password;
        }

        public String getUsername()
        {
            return this.username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.txtEmail.Text == username && this.txtPassword.Text == password)
            {
                this.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                this.lblError.Visible = true;
            }


            
        }
    }
}
