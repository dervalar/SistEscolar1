using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Excepciones
{
    public class LegajoYaExisteException : Exception
    {
        public int Legajo { get; }
        public LegajoYaExisteException(int legajo)
        : base($" Ya existe un alumno con legajo {legajo}.")
        {
            Legajo = legajo;
        }
    }
}
