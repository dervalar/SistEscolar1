namespace SistemaEscolar.UI
{
    partial class FormMateria
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
            Codigo = new System.Windows.Forms.Label();
            Nombre = new System.Windows.Forms.Label();
            Cupo = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            txtCodigo = new System.Windows.Forms.TextBox();
            txtCupo = new System.Windows.Forms.TextBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // Codigo
            // 
            Codigo.AutoSize = true;
            Codigo.Location = new System.Drawing.Point(12, 72);
            Codigo.Name = "Codigo";
            Codigo.Size = new System.Drawing.Size(58, 20);
            Codigo.TabIndex = 0;
            Codigo.Text = "Codigo";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new System.Drawing.Point(12, 19);
            Nombre.Name = "Nombre";
            Nombre.Size = new System.Drawing.Size(64, 20);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            // 
            // Cupo
            // 
            Cupo.AutoSize = true;
            Cupo.Location = new System.Drawing.Point(12, 125);
            Cupo.Name = "Cupo";
            Cupo.Size = new System.Drawing.Size(44, 20);
            Cupo.TabIndex = 2;
            Cupo.Text = "Cupo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(116, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(125, 27);
            txtNombre.TabIndex = 3;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new System.Drawing.Point(116, 65);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(125, 27);
            txtCodigo.TabIndex = 4;
            // 
            // txtCupo
            // 
            txtCupo.Location = new System.Drawing.Point(116, 122);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new System.Drawing.Size(125, 27);
            txtCupo.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(55, 172);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(94, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancelar.Location = new System.Drawing.Point(218, 172);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(94, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormMateria
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(362, 213);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtCupo);
            Controls.Add(txtCodigo);
            Controls.Add(txtNombre);
            Controls.Add(Cupo);
            Controls.Add(Nombre);
            Controls.Add(Codigo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMateria";
            Text = "Agregar Materia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Cupo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}