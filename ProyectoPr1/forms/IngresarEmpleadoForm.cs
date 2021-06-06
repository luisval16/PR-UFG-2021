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
    public partial class IngresarEmpleadoForm : Form
    {

        MenuForm menuForm;

        public IngresarEmpleadoForm(MenuForm menuForm)
        {
            InitializeComponent();
            this.menuForm = menuForm;
            this.textBoxID.Text = this.getLastId();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Al hacer click, se crea un nuevo objejto de la clase Empleado 
            //El objeto toma la información ingresada por el usuario y se guarda en sus propiedades
            Empleado ex1 = new Empleado();
            ex1.Id = textBoxID.Text;
            ex1.Nombre = textBoxNombre.Text;
            ex1.Apellido = textBoxApellido.Text;
            ex1.Username = textBoxUsername.Text;
            ex1.Email = textBoxEmail.Text;
            ex1.Password = textBoxPassword.Text;

            try
            {
                ex1.Edad = int.Parse(textBoxEdad.Text);
            }
            catch (Exception)
            {

                ex1.Edad = 0;
            }

            
            //Para el caso del radio button se asigna la propedad Genero con un condicional if
            if (radioButtonMasculino.Checked == true)
            {
                ex1.Genero = "Masculino";
            }
            else
            {
                ex1.Genero = "Femenino";
            }
            ex1.Puesto = textBoxCargo.Text;
            //una vez asignadas todas las propiedades del nuevo objeto
            //se ingresa toda la información a la tabla con el método addEmpleado
            menuForm.addEmpleado(ex1);
            //Y al final se limpian todos los campos y la form se deja lista para añadir un nuevo empleado.
            textBoxID.Clear();
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxUsername.Clear();
            textBoxEmail.Clear();
            textBoxPassword.Clear();
            textBoxEdad.Clear();
            textBoxCargo.Clear();

            //Manejo de fin de formulario
            DialogResult dialogResult = MessageBox.Show("Empleado ingresado exitosamente! \n Desea agregar otro empleado?","Resultado",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
            else
            {
                this.textBoxID.Text = this.getLastId();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //Metodo para obtener el siguiente Id en la lista
        private String getLastId()
        {
            String nextId = "0";
            int size = this.menuForm.getEmpleados().Count;
            String lastId = this.menuForm.getEmpleados()[size - 1].Id;
            try
            {
                nextId = (int.Parse(lastId)+1).ToString();
            }
            catch (Exception)
            {

                
            }

            return nextId;
        }
    }
}
