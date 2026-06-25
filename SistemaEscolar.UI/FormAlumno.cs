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
    public partial class FormAlumno : Form
    {
        private readonly EscolarControllerUI _controller;
        public FormAlumno(EscolarControllerUI controller)
        {
            InitializeComponent();
            _controller = controller;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación básica de campos vacíos antes de llamar al controller
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text) ||
            string.IsNullOrWhiteSpace(txtLegajo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.",
                "Campos incompletos",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // El controller hace la validación de dominio (legajo único, etc.)
            // y muestra MessageBox si hay un error.
            // Si retorna true, la operación fue exitosa: cerramos el formulario.
            bool exito = _controller.AgregarAlumno(
            txtNombre.Text.Trim(),
            txtEmail.Text.Trim(),
            txtLegajo.Text.Trim()
            );
            if (exito)
                Close(); // FormPrincipal ya se actualizó via Observer
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // Validación básica de campos vacíos antes de llamar al controller
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text) ||
            string.IsNullOrWhiteSpace(txtLegajo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.",
                "Campos incompletos",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // El controller hace la validación de dominio (legajo único, etc.)
            // y muestra MessageBox si hay un error.
            // Si retorna true, la operación fue exitosa: cerramos el formulario.
            bool exito = _controller.AgregarAlumno(
            txtNombre.Text.Trim(),
            txtEmail.Text.Trim(),
            txtLegajo.Text.Trim()
            );
            if (exito)
                Close(); // FormPrincipal ya se actualizó via Observer
        }
    }
}
