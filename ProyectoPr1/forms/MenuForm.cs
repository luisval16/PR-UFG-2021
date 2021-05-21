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


        public void addEmpleado(Empleado empleado)
        {
            this.empleados.Add(empleado);
        }

        public List<Empleado> GetEmpleados()
        {
            return this.empleados;
        }

        public void setUsername(String username)
        {
            this.lblUsername.Text = username;
        }

        public String getUsername()
        {
            return this.lblUsername.Text;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresarEmpleadoForm ingresarEmpleadoForm = new IngresarEmpleadoForm(this) {  TopLevel = false, TopMost = true};
            this.pContainer.Controls.Add(ingresarEmpleadoForm);
            ingresarEmpleadoForm.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult =  DialogResult.No;
        }
    }
}
