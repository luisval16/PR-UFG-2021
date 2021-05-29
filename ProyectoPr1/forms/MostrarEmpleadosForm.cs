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

        //Lista de empleados a nivel de form
        List<Empleado> empleados = new List<Empleado>();
        //Variable para saber si se ha modificado algo
        private bool modified = false;
        //Instancia del menu para pasar variables
        private MenuForm menuForm;

        public MostrarEmpleadosForm(MenuForm menuForm)
        {
            InitializeComponent();
            this.menuForm = menuForm;
            //Lenamos el datagridview
            popularTabla(menuForm.getEmpleados());
            //No dejamos modificar el Id
            this.dgvEmpleados.Columns["id"].ReadOnly = true;
        }

        //Metodo para popular la tabla
        private void popularTabla(List<Empleado> lista)
        {

            DataTable dt = new DataTable();
            foreach (Empleado empleado in lista)
            {
                if (dt.Columns.Count == 0)
                {
                    foreach (var prop in empleado.GetType().GetProperties())
                    {
                        dt.Columns.Add(new DataColumn(prop.Name, typeof(string)));
                        //dt.Rows.Add(prop.GetValue(empleado, null));
                    }
                }
                
                dt.Rows.Add(empleado.Id, empleado.Nombre, empleado.Apellido,
                    empleado.Username,empleado.Email, empleado.Password,
                        empleado.Edad,empleado.Genero,empleado.Genero);
            }
            this.dgvEmpleados.DataSource = dt;
        }


        //Metodo para no mostrar el password en texto plano
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 5 || e.ColumnIndex == 10) && e.Value != null)
            {
                this.dgvEmpleados.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('\u25CF', e.Value.ToString().Length);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string msg = String.Format(dgvEmpleados.Rows[e.RowIndex].Cells[e.ColumnIndex].ToString());
            //this.Text = msg;
        }


        //Metodo para cambiar el color de la celda cuando se modifica
        private void DataGridView1_CellValueChanged(
            object sender, DataGridViewCellEventArgs e)
        {


            dgvEmpleados.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
            modified = true;
            //string msg = String.Format(dgvEmpleados.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            //this.Text = msg;

        }


        //Metodo para verificar si hay cambios y el usuario cierra el form
        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // determinar si se ha modificado algo
            if (this.modified)
            {
                // Mostrar mensaje de confirmación
                if (MessageBox.Show("Desea guardar los cambios hechos?", "Actualizar Empleado",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Cancelar el evento de cerrado
                    e.Cancel = true;

                    // Llamar metodo de actualizar cambios
                    this.actualizarEmpleados();
                }
                else
                {
                    refrescarTabla();
                }
            }
        }


        //Metodo para actializar listado principal de empleados segun cambios en tabla
        private void actualizarEmpleados()
        {
            this.empleados = menuForm.getEmpleados();
            int rowCount = this.dgvEmpleados.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                
                //si el indice de cell es 0 significa que es la columna del id
                    
                if (dgvEmpleados.Rows[i].Cells[0].Value.ToString() == empleados[i].Id)
                {
                    //si el id es igual significa que debemos refrescar este empleado
                    empleados[i].Nombre = dgvEmpleados.Rows[i].Cells[1].Value == null? null: dgvEmpleados.Rows[i].Cells[1].Value.ToString();
                    empleados[i].Apellido = dgvEmpleados.Rows[i].Cells[2].Value == null?null: dgvEmpleados.Rows[i].Cells[2].Value.ToString();
                    empleados[i].Username = dgvEmpleados.Rows[i].Cells[3].Value == null? null: dgvEmpleados.Rows[i].Cells[3].Value.ToString();
                    empleados[i].Email = dgvEmpleados.Rows[i].Cells[4].Value == null? null: dgvEmpleados.Rows[i].Cells[4].Value.ToString();
                    empleados[i].Password = dgvEmpleados.Rows[i].Cells[5].Value == null? null: dgvEmpleados.Rows[i].Cells[5].Value.ToString();

                    try
                    {
                        empleados[i].Edad = Int32.Parse(dgvEmpleados.Rows[i].Cells[6].Value.ToString());
                    }
                    catch (Exception)
                    {

                        empleados[i].Edad = 0;
                    }

                    empleados[i].Genero = dgvEmpleados.Rows[i].Cells[7].Value == null? null: dgvEmpleados.Rows[i].Cells[7].Value.ToString();
                    empleados[i].Puesto = dgvEmpleados.Rows[i].Cells[8].Value==null?null : dgvEmpleados.Rows[i].Cells[8].Value.ToString();
                    
                }
                    
                
            }

            this.modified = false;
            Limpiar();
            this.menuForm.setEmpleados(this.empleados);
            
        }


        //metodo para limpiar las celdas a color blanco y re-popular tabla
        private void Limpiar()
        {
            for (int i = 0; i < this.dgvEmpleados.RowCount; i++)
            {
                for (int j = 0; j < this.dgvEmpleados.ColumnCount; j++)
                {
                    this.dgvEmpleados.Rows[i].Cells[j].Style.BackColor = Color.White;

                }
            }
            this.popularTabla(this.empleados);
        }

        //Metodo para obtener listado de empleados original
        private void refrescarTabla()
        {
            List<Empleado> empl = this.menuForm.getEmpleados();
            this.popularTabla(empl);
        }

        //Metodo para guardar cambios
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            // Mostrar mensaje de confirmación
            if (MessageBox.Show("Desea guardar los cambios hechos?", "Actualizar Empleado",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Llamar metodo de actualizar cambios
                this.actualizarEmpleados();
            }
            else
            {
                refrescarTabla();
                this.modified = false;
            }
            
        }
    }
}
