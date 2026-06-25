namespace SistemaEscolar.UI
{
    partial class FormAlumno
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
            Nombre = new System.Windows.Forms.Label();
            Mail = new System.Windows.Forms.Label();
            Legajo = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtLegajo = new System.Windows.Forms.TextBox();
            btnGuardar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new System.Drawing.Point(12, 22);
            Nombre.Name = "Nombre";
            Nombre.Size = new System.Drawing.Size(64, 20);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            Nombre.Click += label1_Click;
            // 
            // Mail
            // 
            Mail.AutoSize = true;
            Mail.Location = new System.Drawing.Point(12, 75);
            Mail.Name = "Mail";
            Mail.Size = new System.Drawing.Size(38, 20);
            Mail.TabIndex = 1;
            Mail.Text = "Mail";
            Mail.Click += label2_Click;
            // 
            // Legajo
            // 
            Legajo.AutoSize = true;
            Legajo.Location = new System.Drawing.Point(12, 133);
            Legajo.Name = "Legajo";
            Legajo.Size = new System.Drawing.Size(54, 20);
            Legajo.TabIndex = 2;
            Legajo.Text = "Legajo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(82, 19);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(82, 75);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(125, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new System.Drawing.Point(82, 133);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new System.Drawing.Size(125, 27);
            txtLegajo.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(49, 183);
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
            btnCancelar.Location = new System.Drawing.Point(223, 186);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(94, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormAlumno
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(362, 213);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtLegajo);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(Legajo);
            Controls.Add(Mail);
            Controls.Add(Nombre);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormAlumno";
            Text = "Agregar Alumno";
            Load += FormAlumno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Label Legajo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}