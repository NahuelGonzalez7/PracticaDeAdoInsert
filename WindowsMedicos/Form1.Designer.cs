
namespace WindowsMedicos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridMedicos = new System.Windows.Forms.DataGridView();
            this.btnGuardarMedico = new System.Windows.Forms.Button();
            this.lblidNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNroMatricula = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNroMatricula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbEspecialidades = new System.Windows.Forms.ComboBox();
            this.cbTraerEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblTraerPorEspecialidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMedicos
            // 
            this.gridMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMedicos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridMedicos.Location = new System.Drawing.Point(0, 158);
            this.gridMedicos.Name = "gridMedicos";
            this.gridMedicos.Size = new System.Drawing.Size(622, 292);
            this.gridMedicos.TabIndex = 0;
            // 
            // btnGuardarMedico
            // 
            this.btnGuardarMedico.Location = new System.Drawing.Point(345, 61);
            this.btnGuardarMedico.Name = "btnGuardarMedico";
            this.btnGuardarMedico.Size = new System.Drawing.Size(111, 45);
            this.btnGuardarMedico.TabIndex = 1;
            this.btnGuardarMedico.Text = "Guardar";
            this.btnGuardarMedico.UseVisualStyleBackColor = true;
            this.btnGuardarMedico.Click += new System.EventHandler(this.btnGuardarMedico_Click);
            // 
            // lblidNombre
            // 
            this.lblidNombre.AutoSize = true;
            this.lblidNombre.Location = new System.Drawing.Point(30, 19);
            this.lblidNombre.Name = "lblidNombre";
            this.lblidNombre.Size = new System.Drawing.Size(44, 13);
            this.lblidNombre.TabIndex = 2;
            this.lblidNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(30, 57);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNroMatricula
            // 
            this.lblNroMatricula.AutoSize = true;
            this.lblNroMatricula.Location = new System.Drawing.Point(30, 93);
            this.lblNroMatricula.Name = "lblNroMatricula";
            this.lblNroMatricula.Size = new System.Drawing.Size(90, 13);
            this.lblNroMatricula.TabIndex = 4;
            this.lblNroMatricula.Text = "Numero Matricula";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(154, 50);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // txtNroMatricula
            // 
            this.txtNroMatricula.Location = new System.Drawing.Point(154, 86);
            this.txtNroMatricula.Name = "txtNroMatricula";
            this.txtNroMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtNroMatricula.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // cbEspecialidades
            // 
            this.cbEspecialidades.FormattingEnabled = true;
            this.cbEspecialidades.Location = new System.Drawing.Point(378, 11);
            this.cbEspecialidades.Name = "cbEspecialidades";
            this.cbEspecialidades.Size = new System.Drawing.Size(121, 21);
            this.cbEspecialidades.TabIndex = 9;
            // 
            // cbTraerEspecialidad
            // 
            this.cbTraerEspecialidad.FormattingEnabled = true;
            this.cbTraerEspecialidad.Location = new System.Drawing.Point(283, 123);
            this.cbTraerEspecialidad.Name = "cbTraerEspecialidad";
            this.cbTraerEspecialidad.Size = new System.Drawing.Size(216, 21);
            this.cbTraerEspecialidad.TabIndex = 10;
            this.cbTraerEspecialidad.SelectionChangeCommitted += new System.EventHandler(this.cbTraerEspecialidad_SelectionChangeCommitted);
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(287, 15);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 11;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblTraerPorEspecialidad
            // 
            this.lblTraerPorEspecialidad.AutoSize = true;
            this.lblTraerPorEspecialidad.Location = new System.Drawing.Point(117, 131);
            this.lblTraerPorEspecialidad.Name = "lblTraerPorEspecialidad";
            this.lblTraerPorEspecialidad.Size = new System.Drawing.Size(113, 13);
            this.lblTraerPorEspecialidad.TabIndex = 12;
            this.lblTraerPorEspecialidad.Text = "Traer por Especialidad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.lblTraerPorEspecialidad);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.cbTraerEspecialidad);
            this.Controls.Add(this.cbEspecialidades);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNroMatricula);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblNroMatricula);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblidNombre);
            this.Controls.Add(this.btnGuardarMedico);
            this.Controls.Add(this.gridMedicos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMedicos;
        private System.Windows.Forms.Button btnGuardarMedico;
        private System.Windows.Forms.Label lblidNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNroMatricula;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNroMatricula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbEspecialidades;
        private System.Windows.Forms.ComboBox cbTraerEspecialidad;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblTraerPorEspecialidad;
    }
}

