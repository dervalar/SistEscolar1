using SistEscolar1.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Model
{
    internal class Materia : IInscribible, IReportable
    {
        public string Codigo { get; private set; }
        public string Nombre { get; private set; }
        public int Cupo { get; private set; }

        private List<Persona> inscriptos = new List<Persona>();

        public Materia(string codigo, string nombre, int cupo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Cupo = cupo;
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
                    }
                    else
                    {
                        Console.WriteLine("Ya no hay más cupos disponibles...");
                    }
                }
                else
                {
                    Console.WriteLine($"{p.Nombre} ya se encuentra inscripto...");
                }
            }
            else if (p is Docente)
            {
                Console.WriteLine($"{p.Nombre} ya se encuentra inscripto...");
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
