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

        //variables para almacenar campos del formulario
        private String username = "";
        private String password = "";

        //usuario que va a conectarse
        private Empleado currentUser;
        //Listado de usuarios en memoria para validar el inicio de sesión
        private List<Empleado> empleados;


        //metodo constructor
        public LoginForm()
        {
            InitializeComponent();
            //dejamos en blanco los campos del formulario
            this.txtEmail.Text = username;
            this.txtPassword.Text = password;
            //Inicializamos el usuario Administrador
            currentUser = new Empleado();
            currentUser.Nombre = "Administrador";
            currentUser.Username = "admin";
            currentUser.Password = "admin123";
            
        }

        //Metodo setter de la lista de empleados
        public void setEmpleados(List<Empleado> empleados)
        {
            this.empleados = empleados;
        }

        //metodo getter para obtener el nombre de usuario fuera de esta clase
        public String getUsername()
        {
            return this.username;
        }

        //Metodo getter para obtener el usuario que inició sesión fuera de esta clase
        public Empleado getCurrentUser() {
            return this.currentUser;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        //Evento para iniciar sesión
        private void button1_Click(object sender, EventArgs e)
        {
            // se llama la metodo que valida si el usuario y contraseña coinciden con los usuarios registrados
            currentUser = validarUsuario();
            //Si el usuario es diferente de nulo entonces si existe y se procede al menu principal despues de limpiar los campos del formulario de login
            if (currentUser != null)
            {
                //se limpia el formulario de login
                limpiar();
                //se cierra el formulario de login
                this.Close();
                //se asigna el valor ok al reusultado de dialogo para que en el archivo program.cs se muestre el menu principal
                DialogResult = DialogResult.OK;
            }
            else
            {
                //si el usuario es nulo entonces las credenciales son incorrectas o el usuario no existe
                this.lblError.Visible = true;
            }


            
        }



        //valida si el usuario existe en el sistema, comparando el username y password con los de los usuarios en la lista
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


        //limpia los campos del formulario de login
        private void limpiar()
        {
            this.lblError.Visible = false;
            this.txtEmail.Text = "";
            this.txtPassword.Text = "";
        }
    }
}
