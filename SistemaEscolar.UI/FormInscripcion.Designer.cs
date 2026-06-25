namespace SistemaEscolar.UI
{
    partial class FormInscripcion
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
            cboAlumnos = new System.Windows.Forms.ComboBox();
            btnInscribir = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // cboAlumnos
            // 
            cboAlumnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboAlumnos.FormattingEnabled = true;
            cboAlumnos.Location = new System.Drawing.Point(108, 28);
            cboAlumnos.Name = "cboAlumnos";
            cboAlumnos.Size = new System.Drawing.Size(151, 28);
            cboAlumnos.TabIndex = 0;
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new System.Drawing.Point(46, 89);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new System.Drawing.Size(94, 29);
            btnInscribir.TabIndex = 1;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancelar.Location = new System.Drawing.Point(214, 89);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(94, 29);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormInscripcion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(362, 153);
            Controls.Add(btnCancelar);
            Controls.Add(btnInscribir);
            Controls.Add(cboAlumnos);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "FormInscripcion";
            Text = "FormInscripcion";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox cboAlumnos;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnCancelar;
    }
}