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
    public partial class FormMateria : Form
    {
        private readonly EscolarControllerUI _controller;
        public FormMateria(EscolarControllerUI controller)
        {
            InitializeComponent();
            _controller = controller;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
            string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtCupo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.",
                "Campos incompletos",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool exito = _controller.AgregarMateria(
            txtCodigo.Text.Trim(),
            txtNombre.Text.Trim(),
            txtCupo.Text.Trim()
            );
            if (exito) Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
            string.IsNullOrWhiteSpace(txtNombre.Text) ||
            string.IsNullOrWhiteSpace(txtCupo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.",
                "Campos incompletos",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool exito = _controller.AgregarMateria(
            txtCodigo.Text.Trim(),
            txtNombre.Text.Trim(),
            txtCupo.Text.Trim()
            );
            if (exito) Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
