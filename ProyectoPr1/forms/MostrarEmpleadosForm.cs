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
        private bool modified = false;
        private MenuForm menuForm;

        public MostrarEmpleadosForm(MenuForm menuForm)
        {
            InitializeComponent();
            this.menuForm = menuForm;
            this.empleados = menuForm.getEmpleados();
            this.dgvEmpleados.DataSource = this.empleados;
            this.dgvEmpleados.Columns["id"].ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string msg = String.Format(dgvEmpleados.Rows[e.RowIndex].Cells[e.ColumnIndex].ToString());
            //this.Text = msg;
        }


        private void DataGridView1_CellValueChanged(
            object sender, DataGridViewCellEventArgs e)
        {


            dgvEmpleados.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
            modified = true;
            //string msg = String.Format(dgvEmpleados.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            //this.Text = msg;

        }


        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Determine if text has changed in the textbox by comparing to original text.
            if (this.modified)
            {
                // Display a MsgBox asking the user to save changes or abort.
                if (MessageBox.Show("Desea guardar los cambios hechos?", "Actualizar Empleado",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Cancel the Closing event from closing the form.
                    e.Cancel = true;
                    // Call method to save file...
                }
                else
                {
                    Limpiar();
                }
            }
        }

        private void actualizarEmpleados()
        {
            
            for (int i = 0; i < this.dgvEmpleados.RowCount; i++)
            {
                
                //si el indice de cell es 0 significa que es la columna del id
                    
                if (dgvEmpleados.Rows[i].Cells[0].Value.ToString() == empleados[i].Id)
                {
                    //si el id es igual significa que debemos refrescar este empleado
                    empleados[i].Nombre = dgvEmpleados.Rows[i].Cells[1].Value.ToString();
                    empleados[i].Apellido = dgvEmpleados.Rows[i].Cells[2].Value == null?null: dgvEmpleados.Rows[i].Cells[2].Value.ToString();
                    empleados[i].Username = dgvEmpleados.Rows[i].Cells[3].Value.ToString();
                    empleados[i].Email = dgvEmpleados.Rows[i].Cells[4].Value.ToString();
                    empleados[i].Password = dgvEmpleados.Rows[i].Cells[5].Value.ToString();
                    empleados[i].Edad = Int32.Parse(dgvEmpleados.Rows[i].Cells[6].Value.ToString());
                    empleados[i].Genero = dgvEmpleados.Rows[i].Cells[7].Value.ToString();
                    empleados[i].Puesto = dgvEmpleados.Rows[i].Cells[8].Value.ToString();
                    
                }
                    
                
            }

            Limpiar();
            this.menuForm.setEmpleados(this.empleados);
            
        }


        private void Limpiar()
        {
            for (int i = 0; i < this.dgvEmpleados.RowCount; i++)
            {
                for (int j = 0; j < this.dgvEmpleados.ColumnCount; j++)
                {
                    this.dgvEmpleados.Rows[i].Cells[j].Style.BackColor = Color.White;

                }
            }
            this.dgvEmpleados.DataSource = this.empleados;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actualizarEmpleados();
        }
    }
}
