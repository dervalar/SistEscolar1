using System.Drawing;
using System.Windows.Forms;

namespace SistemaEscolar.UI

{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Alumno = new TabPage();
            Materias = new TabPage();
            dgvAlumnos = new DataGridView();
            btnAgregarAlumno = new Button();
            btnEditarAlumno = new Button();
            btnEliminarAlumno = new Button();
            dgvMaterias = new DataGridView();
            btnAgregarMateria = new Button();
            btnEditarMateria = new Button();
            btnEliminarMateria = new Button();
            btnInscribir = new Button();
            tabControl1.SuspendLayout();
            Alumno.SuspendLayout();
            Materias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Alumno);
            tabControl1.Controls.Add(Materias);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(858, 529);
            tabControl1.TabIndex = 0;
            // 
            // Alumno
            // 
            Alumno.Controls.Add(btnEliminarAlumno);
            Alumno.Controls.Add(btnEditarAlumno);
            Alumno.Controls.Add(btnAgregarAlumno);
            Alumno.Controls.Add(dgvAlumnos);
            Alumno.Location = new Point(4, 29);
            Alumno.Name = "Alumno";
            Alumno.Padding = new Padding(3);
            Alumno.Size = new Size(850, 496);
            Alumno.TabIndex = 0;
            Alumno.Text = "Alumnos";
            Alumno.UseVisualStyleBackColor = true;
            // 
            // Materias
            // 
            Materias.Controls.Add(btnInscribir);
            Materias.Controls.Add(btnEliminarMateria);
            Materias.Controls.Add(btnEditarMateria);
            Materias.Controls.Add(btnAgregarMateria);
            Materias.Controls.Add(dgvMaterias);
            Materias.Location = new Point(4, 29);
            Materias.Name = "Materias";
            Materias.Padding = new Padding(3);
            Materias.Size = new Size(850, 496);
            Materias.TabIndex = 1;
            Materias.Text = "Materias";
            Materias.UseVisualStyleBackColor = true;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(13, 10);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.RowTemplate.Height = 29;
            dgvAlumnos.Size = new Size(834, 402);
            dgvAlumnos.TabIndex = 0;
            // 
            // btnAgregarAlumno
            // 
            btnAgregarAlumno.Location = new Point(51, 437);
            btnAgregarAlumno.Name = "btnAgregarAlumno";
            btnAgregarAlumno.Size = new Size(205, 38);
            btnAgregarAlumno.TabIndex = 1;
            btnAgregarAlumno.Text = "Agregar Alumno";
            btnAgregarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnEditarAlumno
            // 
            btnEditarAlumno.Location = new Point(331, 437);
            btnEditarAlumno.Name = "btnEditarAlumno";
            btnEditarAlumno.Size = new Size(211, 38);
            btnEditarAlumno.TabIndex = 2;
            btnEditarAlumno.Text = "Editar Alumno";
            btnEditarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnEliminarAlumno
            // 
            btnEliminarAlumno.Location = new Point(587, 437);
            btnEliminarAlumno.Name = "btnEliminarAlumno";
            btnEliminarAlumno.Size = new Size(217, 38);
            btnEliminarAlumno.TabIndex = 3;
            btnEliminarAlumno.Text = "Eliminar Alumno";
            btnEliminarAlumno.UseVisualStyleBackColor = true;
            // 
            // dgvMaterias
            // 
            dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Location = new Point(12, 17);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.ReadOnly = true;
            dgvMaterias.RowHeadersWidth = 51;
            dgvMaterias.RowTemplate.Height = 29;
            dgvMaterias.Size = new Size(832, 411);
            dgvMaterias.TabIndex = 0;
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.Location = new Point(41, 441);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new Size(187, 34);
            btnAgregarMateria.TabIndex = 1;
            btnAgregarMateria.Text = "Agregar Materia";
            btnAgregarMateria.UseVisualStyleBackColor = true;
            // 
            // btnEditarMateria
            // 
            btnEditarMateria.Location = new Point(267, 441);
            btnEditarMateria.Name = "btnEditarMateria";
            btnEditarMateria.Size = new Size(189, 34);
            btnEditarMateria.TabIndex = 2;
            btnEditarMateria.Text = "Editar Materia";
            btnEditarMateria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMateria
            // 
            btnEliminarMateria.Location = new Point(491, 441);
            btnEliminarMateria.Name = "btnEliminarMateria";
            btnEliminarMateria.Size = new Size(198, 34);
            btnEliminarMateria.TabIndex = 3;
            btnEliminarMateria.Text = "Eliminar Materia";
            btnEliminarMateria.UseVisualStyleBackColor = true;
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new Point(695, 471);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(155, 25);
            btnInscribir.TabIndex = 4;
            btnInscribir.Text = "Inscribir Alumno";
            btnInscribir.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(882, 553);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormPrincipal";
            Text = "Sistema Escolar";
            tabControl1.ResumeLayout(false);
            Alumno.ResumeLayout(false);
            Materias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Alumno;
        private TabPage Materias;
        private Button btnEliminarAlumno;
        private Button btnEditarAlumno;
        private Button btnAgregarAlumno;
        private DataGridView dgvAlumnos;
        private Button btnInscribir;
        private Button btnEliminarMateria;
        private Button btnEditarMateria;
        private Button btnAgregarMateria;
        private DataGridView dgvMaterias;
    }
}
