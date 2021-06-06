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


        private List<Empleado> empleados = new List<Empleado>();


        



        public MenuForm()
        {
            InitializeComponent();
            
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["IngresarEmpleadoForm"] as IngresarEmpleadoForm) == null)
            {
                IngresarEmpleadoForm ingresarEmpleadoForm = new IngresarEmpleadoForm(this) { TopLevel = false, TopMost = true };
                this.pContainer.Controls.Add(ingresarEmpleadoForm);
                ingresarEmpleadoForm.Show();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult =  DialogResult.No;
        }

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
