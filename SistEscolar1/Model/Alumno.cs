using SistEscolar1.Model.Interface;
using SistEscolar1.Model.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Model
{
     public class Alumno : Persona, ICalificable, IReportable
    {
        public int Legajo { get; private set; }
        private List<double> notas = new List<double>();
        private IStratPromedio _estrategia;
        
        // Permite que el repo JSON lea las notas para guardarlas en disco
        public List<double> ObtenerNotas() => new List<double>(notas);

        // Permite que el repo JSON recargue notas al iniciar
        public void CargarNotas(IEnumerable<double> notas)
        {
            _notas.Clear();
            foreach (var n in notas) _notas.Add(n);
        }

        public Alumno(string nombre, string email, int legajo,
             IStratPromedio estrategia = null) : base(nombre, email)
        {
            Legajo = legajo;
            _estrategia = estrategia ?? new PromedioSimple();

        }

        public override void Presentarse()
        {
            base.Presentarse();
            Console.WriteLine($" Legajo: {Legajo} - {MostrarNotas()}");
        }

        public string MostrarNotas()
        {
            string msj = "NOTAS: ";
            foreach (double d in notas)
            {
                msj += $"{d},";
            }
            return msj;
        }
        public override string ObtenerRol() => "Alumno";

        // ICalificable

        public void AgregarNota(double nota)
        {
            notas.Add(nota);
        }

        public double ObtenerPromedio() => _estrategia.Calcular(notas);

        // IReportable

        public string GenerarReporte()
        {
            return $"Alumno: {Nombre} | Legajo: {Legajo} | Promedio: {ObtenerPromedio():F2}";
        }

        // Estrategia Promedio

        // Permite cambiar la estrategia después de crear el alumno

        public void CambiarEstrategia(IStratPromedio nueva)
        {
            _estrategia = nueva;
        }

       


    }
}
