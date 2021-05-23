
namespace ProyectoPr1.forms
{
    partial class MostrarEmpleadosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvEmpleados.Location = new System.Drawing.Point(0, 24);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowTemplate.Height = 25;
            this.dgvEmpleados.Size = new System.Drawing.Size(800, 426);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvEmpleados.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(160, 24);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar Empleado";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // MostrarEmpleadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MostrarEmpleadosForm";
            this.Text = "Lista de Empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnModificar;
    }
}