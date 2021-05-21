using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPr1.model;

namespace ProyectoPr1
{
    public partial class LoginForm : Form
    {

        private String username = "";
        private String password = "";

        private Empleado currentUser;
        private List<Empleado> empleados;

        public LoginForm()
        {
            InitializeComponent();
            this.txtEmail.Text = username;
            this.txtPassword.Text = password;
            currentUser = new Empleado();
            currentUser.Nombre = "Administrador";
            currentUser.Username = "admin";
            currentUser.Password = "admin123";
            
        }

        public void setEmpleados(List<Empleado> empleados)
        {
            this.empleados = empleados;
        }

        public String getUsername()
        {
            return this.username;
        }

        public Empleado getCurrentUser() {
            return this.currentUser;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentUser = validarUsuario();
            if (currentUser != null)
            {
                limpiar();
                this.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                this.lblError.Visible = true;
            }


            
        }


        private Empleado validarUsuario()
        {
            username = this.txtEmail.Text ;
            password = this.txtPassword.Text ;
            foreach (Empleado empleado in empleados)
            {
                if (username == empleado.Username && password == empleado.Password)
                {
                    return empleado;
                }
            }

            return null;
        }


        private void limpiar()
        {
            this.lblError.Visible = false;
            this.txtEmail.Text = "";
            this.txtPassword.Text = "";
        }
    }
}
