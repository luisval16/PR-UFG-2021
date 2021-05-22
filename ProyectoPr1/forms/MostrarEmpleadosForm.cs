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
    public partial class MostrarEmpleadosForm : Form
    {

        List<Empleado> empleados;

        public MostrarEmpleadosForm(MenuForm menuForm)
        {
            InitializeComponent();
            this.empleados = menuForm.GetEmpleados();
            this.dgvEmpleados.DataSource = this.empleados;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string msg = String.Format("dataGridView1_CellContentClick");
            //this.Text = msg;
        }

        /* void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
         {
             // Clear the row error in case the user presses ESC.   
             this.dgvEmpleados.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;

         }*/


        private void DataGridView1_CellValueChanged(
    object sender, DataGridViewCellEventArgs e)
        {
            // Update the balance column whenever the value of any cell changes.
            string msg = String.Format("DataGridView1_CellValueChanged");
            this.Text = msg;
        }
    }
}
