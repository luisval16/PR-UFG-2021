using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoPr1.model;

namespace ProyectoPr1.forms
{
    public partial class MenuForm : Form
    {

        //lista para almacenar empleados registrados
        private List<Empleado> empleados = new List<Empleado>();


        



        public MenuForm()
        {
            InitializeComponent();
            
        }

        //metodos get y set de encapsulamiento
        public void setEmpleados(List<Empleado> empleados)
        {
            this.empleados = empleados;
        }

        public void addEmpleado(Empleado empleado)
        {
            this.empleados.Add(empleado);
        }

        public List<Empleado> getEmpleados()
        {
            return this.empleados;
        }

        public void setUsername(String username)
        {
            
            this.tspUsername.Text = username;
        }

        public String getUsername()
        {
            return this.tspUsername.Text;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        //abrir formulario de registro de empleados y asegurarse que no se abran varias instancias de este
        private void button1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["IngresarEmpleadoForm"] as IngresarEmpleadoForm) == null)
            {
                IngresarEmpleadoForm ingresarEmpleadoForm = new IngresarEmpleadoForm(this) { TopLevel = false, TopMost = true };
                this.pContainer.Controls.Add(ingresarEmpleadoForm);
                ingresarEmpleadoForm.Show();
            }
        }

        //metodo para cerrar sesion y regresar al login
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult =  DialogResult.No;
        }

        //abrir formulario de listado y edicion de empleados y asegurarse que no se abran varias instancias de este

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            

            if((Application.OpenForms["MostrarEmpleadosForm"] as MostrarEmpleadosForm) == null)
            {
                MostrarEmpleadosForm mostrarEmpleadosForm = new MostrarEmpleadosForm(this) { TopLevel = false, TopMost = true };
                this.pContainer.Controls.Add(mostrarEmpleadosForm);
                mostrarEmpleadosForm.Show();
            }
        }

        private void mainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
