using SistemaEscolar.Core;
using SistEscolar1.Excepciones;
using SistEscolar1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar.UI
{
    public class EscolarControllerUI
    {
        private readonly EscolarModel _model;
        public EscolarControllerUI(EscolarModel model)
        {
            _model = model;
        }
        // ── Alumnos ───────────────────────────────────────────────────────
        public bool AgregarAlumno(string nombre, string email, string legajoTexto)
        {
            try
            {
                int legajo = int.Parse(legajoTexto);
                _model.AgregarAlumno(new Alumno(nombre, email, legajo));
                _model.GuardarTodo();
                return true; // operación exitosa
            }
            catch (LegajoYaExisteException ex)
            {
                MessageBox.Show(ex.Message, "Legajo duplicado",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (FormatException)
            {
                MessageBox.Show("El legajo debe ser un número entero.",
                "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool EliminarAlumno(Alumno alumno)
        {
            var confirmacion = MessageBox.Show(
            $"¿Eliminar al alumno {alumno.Nombre}?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes) return false;
            // Para eliminar necesitamos agregar el método al repositorio (ver Ejercicio 3.B)
            _model.EliminarAlumno(alumno);
            _model.GuardarTodo();
            return true;
        }
        // ── Materias ──────────────────────────────────────────────────────
        public bool AgregarMateria(string codigo, string nombre, string cupoTexto)
        {
            try
            {
                int cupo = int.Parse(cupoTexto);
                _model.AgregarMateria(new Materia(codigo, nombre, cupo));
                _model.GuardarTodo();
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("El cupo debe ser un número entero.",
                "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool EliminarMateria(Materia materia)
        {
            var confirmacion = MessageBox.Show(
            $"¿Eliminar materia {materia.Codigo}?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes) return false;
            // Para eliminar necesitamos agregar el método al repositorio (ver Ejercicio 3.B)
            _model.GuardarTodo();
            return true;
        }
        // ── Inscripciones y notas ─────────────────────────────────────────
        public bool InscribirAlumno(Alumno alumno, Materia materia)
        {
            try
            {
                _model.InscribirAlumno(alumno, materia);
                _model.GuardarTodo();
                return true;
            }
            catch (SinCupoException ex)
            {
                MessageBox.Show(ex.Message, "Sin cupo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Operación inválida",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public void CargarNota(Alumno alumno, double nota)
        {
            _model.CargarNota(alumno, nota);
            _model.GuardarTodo();
        }
    }   
}
