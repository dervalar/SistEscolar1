using SistEscolar1.Model;
using SistEscolar1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Controller
{
    internal class EscolarController
    {

        private readonly EscolarModel _model;
        private readonly EscolarView _view;
        public EscolarController(EscolarModel model, EscolarView view)
        {
            _model = model;
            _view = view;
        }
        public void Ejecutar()
        {
            bool continuar = true;
            while (continuar)
            {
                _view.MostrarMenu();
                string opcion = _view.PedirTexto("");
                switch (opcion)
                {
                    case "1": _view.MostrarPersonas(_model.Personas); break;
                    case "2": AgregarAlumno(); break;
                    case "3": AgregarDocente(); break;
                    case "4": InscribirAlumno(); break;
                    case "5": VerReporteMateria(); break;
                    case "6": AgregarNota(); break;
                    case "7": VerPromedioAlumno(); break;
                    case "0": continuar = false; break;
                    default: _view.MostrarMensaje("Opcion invalida."); break;
                }
            }
        }

        private void AgregarAlumno()
        {
            string nombre = _view.PedirTexto("Nombre: ");
            string email = _view.PedirTexto("Email: ");
            int legajo = _view.PedirEntero("Legajo: ");
            _model.AgregarPersona(new Alumno(nombre, email, legajo));
            _view.MostrarMensaje("Alumno agregado.");
        }
        private void AgregarDocente()
        {
            string nombre = _view.PedirTexto("Nombre: ");
            string email = _view.PedirTexto("Email: ");
            string nro = _view.PedirTexto("Nro empleado: ");
            _model.AgregarPersona(new Docente(nombre, email, nro));
            _view.MostrarMensaje("Docente agregado.");
        }
        private void InscribirAlumno()
        {
            int legajo = _view.PedirEntero("Legajo del alumno: ");
            string codigo = _view.PedirTexto("Codigo de materia: ");
            var alumno = _model.BuscarAlumnoPorLegajo(legajo);
            var materia = _model.BuscarMateriaPorCodigo(codigo);
            if (alumno == null || materia == null)
            {
                _view.MostrarMensaje("Alumno o materia no encontrado.");
                return;
            }
            materia.Inscribir(alumno);
            _view.MostrarMensaje($"Alumno inscripto en {materia.Nombre}.");
        }
        private void VerReporteMateria()
        {
            string codigo = _view.PedirTexto("Codigo de materia: ");
            var materia = _model.BuscarMateriaPorCodigo(codigo);
            if (materia == null)
                _view.MostrarMensaje("Materia no encontrada.");
            else
                _view.MostrarReporte(materia);
        }
        private void VerPromedioAlumno()
        {
            int legajo = _view.PedirEntero("Legajo: ");
            var alumno = _model.BuscarAlumnoPorLegajo(legajo);
            if (alumno == null)
                _view.MostrarMensaje("Alumno no encontrado.");
            else
                _view.MostrarReporte(alumno);
        }
        private void AgregarNota()
        {
            int legajo = _view.PedirEntero("Legajo: ");
            var alumno = _model.BuscarAlumnoPorLegajo(legajo);
            int nota = _view.PedirEntero("Nota del alumno: ");
            alumno.AgregarNota(nota);
        }


    }
}
