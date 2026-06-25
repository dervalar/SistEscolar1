using SistemaEscolar.Core.Model.Observer;
using SistEscolar1.Model;
using System;
using System.Windows.Forms;

namespace SistemaEscolar.UI
{
    public partial class FormPrincipal : Form
    {
        private readonly EscolarModel _model;
        private readonly EscolarControllerUI _controller;
        public FormPrincipal(EscolarModel model, EscolarControllerUI controller)
        {

            InitializeComponent();
            _model = model;
            _controller = controller;
            // Nos suscribimos al Model para recibir notificaciones
            _model.Suscribir(this);
            // Cargamos los datos al abrir
            CargarAlumnos();
            CargarMaterias();
        }
        public void Actualizar(CambioEscolar cambio, object dato)
        {
            // Usamos Invoke para ejecutar en el hilo de la UI (requerido en WinForms)
            if (InvokeRequired)
            {
                Invoke(new Action(() => Actualizar(cambio, dato)));
                return;
            }
            switch (cambio)
            {
                case CambioEscolar.AlumnoAgregado:
                case CambioEscolar.AlumnoEliminado:
                    CargarAlumnos();
                    break;
                case CambioEscolar.MateriaAgregada:
                    CargarMaterias();
                    break;
                case CambioEscolar.AlumnoInscripto:
                    CargarMaterias(); // actualiza el contador de inscriptos
                    break;
            }
        }
        // ── Carga de datos en las tablas ──────────────────────────────────
        private void CargarAlumnos()
        {
            dgvAlumnos.DataSource = null;
            dgvAlumnos.DataSource = _model.ObtenerAlumnos();
            // Ajustamos las columnas para que se lean bien
            if (dgvAlumnos.Columns.Count > 0)
            {
                dgvAlumnos.AutoResizeColumns();
            }
        }
        private void CargarMaterias()
        {
            dgvMaterias.DataSource = null;
            dgvMaterias.DataSource = _model.ObtenerMaterias();
            if (dgvMaterias.Columns.Count > 0)
                dgvMaterias.AutoResizeColumns();
        }
        // ── Eventos de botones — Alumnos ──────────────────────────────────
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            // Abre el formulario de alta. Al cerrar, el Observer ya actualizó la tabla.
            using var form = new FormAlumno(_controller);
            form.ShowDialog();
        }
        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow?.DataBoundItem is Alumno alumno)
                _controller.EliminarAlumno(alumno);
            else
                MessageBox.Show("Seleccioná un alumno de la tabla.",
                "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // ── Eventos de botones — Materias ─────────────────────────────────
        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            using var form = new FormMateria(_controller);
            form.ShowDialog();
        }
        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.CurrentRow?.DataBoundItem is Materia materia)
            {
                using var form = new FormInscripcion(_controller, _model, materia);
                form.ShowDialog();
            }
            else
                MessageBox.Show("Seleccioná una materia de la tabla.",
                "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Liberar la suscripción al cerrar el formulario
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _model.GuardarTodo();
            _model.Desuscribir(this);
            base.OnFormClosed(e);
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarAlumno_Click_1(object sender, EventArgs e)
        {
            using var form = new FormAlumno(_controller);
            form.ShowDialog();
        }

        private void btnEditarAlumno_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarAlumno_Click_1(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow?.DataBoundItem is Alumno alumno)
                _controller.EliminarAlumno(alumno);
            else
                MessageBox.Show("Seleccioná un alumno de la tabla.",
                "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAgregarMateria_Click_1(object sender, EventArgs e)
        {
            using var form = new FormMateria(_controller);
            form.ShowDialog();
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.CurrentRow?.DataBoundItem is Materia materia)
                _controller.EliminarMateria(materia);
            else
                MessageBox.Show("Seleccioná un alumno de la tabla.",
                "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInscribir_Click_1(object sender, EventArgs e)
        {
            if (dgvMaterias.CurrentRow?.DataBoundItem is Materia materia)
            {
                using var form = new FormInscripcion(_controller, _model, materia);
                form.ShowDialog();
            }
            else
                MessageBox.Show("Seleccioná una materia de la tabla.",
                "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
