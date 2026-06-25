using SistEscolar1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar.UI
{
    public partial class FormInscripcion : Form
    {
        private readonly EscolarControllerUI _controller;
        private readonly EscolarModel _model;
        private readonly Materia _materia;
        public FormInscripcion(EscolarControllerUI controller,
                                EscolarModel model, Materia materia)
        {
            InitializeComponent();
            _controller = controller;
            _model = model;
            _materia = materia;
            // Cargamos la lista de alumnos en el ComboBox.
            // Mostramos el nombre pero el objeto completo queda guardado.
            cboAlumnos.DataSource = _model.ObtenerAlumnos();
            cboAlumnos.DisplayMember = "Nombre"; // qué texto mostrar
            cboAlumnos.ValueMember = "Legajo"; // qué valor usar internamente
            Text = $"Inscribir en: {materia.Nombre}";
        }
        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (cboAlumnos.SelectedItem is Alumno alumno)
            {
                bool exito = _controller.InscribirAlumno(alumno, _materia);
                if (exito) Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        private void btnInscribir_Click_1(object sender, EventArgs e)
        {
            if (cboAlumnos.SelectedItem is Alumno alumno)
            {
                bool exito = _controller.InscribirAlumno(alumno, _materia);
                if (exito) Close();
            }
        }
    }

}
