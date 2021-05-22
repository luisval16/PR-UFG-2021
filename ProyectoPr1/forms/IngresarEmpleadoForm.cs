using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoPr1.forms
{
    public partial class IngresarEmpleadoForm : Form
    {

        MenuForm menuForm;

        public IngresarEmpleadoForm(MenuForm menuForm)
        {
            InitializeComponent();
            this.menuForm = menuForm;
            this.button1.Text = menuForm.getUsername();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuForm.setUsername("cambie!!");
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
    }
}
