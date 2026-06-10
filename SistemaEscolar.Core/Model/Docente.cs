using SistEscolar1.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Model
{
     public class Docente : Persona, IReportable
    {
        public int NoEmpleado { get; private set; }

        public Docente(string nombre, string email, int noEmpleado) :base(nombre, email)
        {
            NoEmpleado = noEmpleado;
        }

        public override void Presentarse()
        {
            base.Presentarse();
            Console.WriteLine($" Número de Empleado: {NoEmpleado}");

        }
        public override string ObtenerRol() => "Docente";

        public string GenerarReporte()
        {
            return $"Docente: {Nombre} | Email: {Email} | Número de Empleado: {NoEmpleado}";
        }
    }
}
