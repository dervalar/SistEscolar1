using SistemaEscolar.Core.Model.Observer;
using SistEscolar1.Excepciones;
using SistEscolar1.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Model
{
    public class Materia : IInscribible, IReportable, ISujetoEscolar
    {
        public string Codigo { get; private set; }
        public string Nombre { get; private set; }
        public int Cupo { get; private set; }

        private List<Persona> inscriptos = new List<Persona>();
        private readonly List<IObservadorEscolar> _observadores = new();

        public Materia(string codigo, string nombre, int cupo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Cupo = cupo;
        }
        // ── Observer ──────────────────────────────────────────────────────
        public void Suscribir(IObservadorEscolar obs) => _observadores.Add(obs);
        public void Desuscribir(IObservadorEscolar obs) => _observadores.Remove(obs);
        public void Notificar(CambioEscolar cambio, object dato)
        {
            // Notifica a cada observador registrado
            foreach (var obs in _observadores)
                obs.Actualizar(cambio, dato);
        }

        public List<Persona> devolverInscriptos()
        {
            return inscriptos;
        }

        // IInscribible

        public void Inscribir(Persona p)
        {
            if (p is Alumno)
            {
                if (!inscriptos.Contains(p))
                {
                    if (inscriptos.Count < Cupo)
                    {
                        inscriptos.Add(p);
                        Console.WriteLine("Se ha añadido correctamente...");
                        Notificar(CambioEscolar.AlumnoInscripto, p);
                    }
                    else
                    {
                        throw new SinCupoException(Nombre);
                    }
                }
                else
                {
                    Console.WriteLine($"{p.Nombre} ya se encuentra inscripto...");
                }
            }
            else if (p is Docente)
            {
                throw new InvalidOperationException(
                    $"{p.Nombre} ya está inscripto en {Nombre}.");
            }
            else
            {
                Console.WriteLine("Error...");
            }



        }

        // IReportable

        public string GenerarReporte()
        {
            return $"Materia: {Nombre} ({Codigo}) | Inscriptos: {inscriptos.Count}/{Cupo}";
        }
    }
}
