using SistemaEscolar.Core.Model.Observer;
using SistEscolar1.Model.Interface;
using SistEscolar1.Model.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Model
{
     public class Alumno : Persona, ICalificable, IReportable, ISujetoEscolar
    {
        public int Legajo { get; private set; }
        public string NombreEstrategia { get; internal set; }

        private List<double> _notas = new List<double>();
        private IStratPromedio _estrategia;
        private readonly List<IObservadorEscolar> _observadores = new();

        // ── Observer ──────────────────────────────────────────────────────
        public void Suscribir(IObservadorEscolar obs) => _observadores.Add(obs);
        public void Desuscribir(IObservadorEscolar obs) => _observadores.Remove(obs);
        public void Notificar(CambioEscolar cambio, object dato)
        {
            // Notifica a cada observador registrado
            foreach (var obs in _observadores)
                obs.Actualizar(cambio, dato);
        }

        // Permite que el repo JSON lea las notas para guardarlas en disco
        public List<double> ObtenerNotas() => new List<double>(_notas);

        // Permite que el repo JSON recargue notas al iniciar
        public void CargarNotas(IEnumerable<double> notas)
        {
            _notas.Clear();
            foreach (var n in notas)
            {
                _notas.Add(n);
                Notificar(CambioEscolar.NotaCargada, n);
            }
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
            foreach (double d in _notas)
            {
                msj += $"{d},";
            }
            return msj;
        }
        public override string ObtenerRol() => "Alumno";

        // ICalificable

        public void AgregarNota(double nota)
        {
            _notas.Add(nota);
        }

        public double ObtenerPromedio() => _estrategia.Calcular(_notas);

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
            Notificar(CambioEscolar.EstrategiaCambiada, _notas);
        }

       


    }
}
