using SistEscolar1.Excepciones;
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
        List<Persona> personas = new List<Persona>();
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
                    case "1": _view.MostrarAlumnos(_model.ObtenerAlumnos()); break;
                    case "2": AgregarAlumno(); break;
                    case "3": AgregarDocente(); break;
                    case "4": InscribirAlumno(); break;
                    case "5": VerReporteMateria(); break;
                    case "6": AgregarNota(); break;
                    case "7": VerPromedioAlumno(); break;
                    case "8": CambiarEstrategia(); break;
                    case "0":
                        _model.GuardarTodo();
                        _view.MostrarMensaje("Datos guardados. Hasta luego!");
                        continuar = false;
                        break;
                    default:
                        _view.MostrarError("Opcion invalida. Ingresa un numero del 0 al 8.");
                        break;
                }
            }
        }

        private void AgregarAlumno()
        {
            try
            {
                string nombre = _view.PedirTexto("Nombre: ");
                string email = _view.PedirTexto("Email: ");
                int legajo = _view.PedirEntero("Legajo: ");
                _model.AgregarAlumno(new Alumno(nombre, email, legajo));
                _model.GuardarTodo();
                _view.MostrarMensaje("Alumno agregado correctamente.");
            }
            catch (LegajoYaExisteException ex)
            {
                _view.MostrarError(ex.Message);
            }
            catch (FormatException)
            {
                _view.MostrarError("El legajo debe ser un número entero.");
            }
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
            try
            {
                int legajo = _view.PedirEntero("Legajo del alumno: ");
                string codigo = _view.PedirTexto("Código de materia: ");
                var alumno = _model.BuscarAlumno(legajo)
                ?? throw new EntidadNoEncontradaException("Alumno", legajo.ToString());
                var materia = _model.BuscarMateria(codigo)
                ?? throw new EntidadNoEncontradaException("Materia", codigo);
                materia.Inscribir(alumno);
                _model.GuardarTodo();
                _view.MostrarMensaje($"{alumno.Nombre} inscripto en {materia.Nombre}.");
            }
            catch (EntidadNoEncontradaException ex) { _view.MostrarError(ex.Message); }
            catch (SinCupoException ex) { _view.MostrarError(ex.Message); }
            catch (InvalidOperationException ex) { _view.MostrarError(ex.Message); }
        }
        private void VerReporteMateria()
        {
            string codigo = _view.PedirTexto("Codigo de materia: ");
            var materia = _model.BuscarMateria(codigo);
            if (materia == null)
                _view.MostrarMensaje("Materia no encontrada.");
            else
                _view.MostrarReporte(materia);
        }
        private void VerPromedioAlumno()
        {
            int legajo = _view.PedirEntero("Legajo: ");
            var alumno = _model.BuscarAlumno(legajo);
            if (alumno == null)
                _view.MostrarMensaje("Alumno no encontrado.");
            else
                _view.MostrarReporte(alumno);
        }
        private void AgregarNota()
        {
            int legajo = _view.PedirEntero("Legajo: ");
            var alumno = _model.BuscarAlumno(legajo);
            int nota = _view.PedirEntero("Nota del alumno: ");
            alumno.AgregarNota(nota);
        }
        private void CambiarEstrategia()
        {

        }

    }
}
