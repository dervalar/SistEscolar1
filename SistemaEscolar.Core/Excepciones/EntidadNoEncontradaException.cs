using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Excepciones
{
    public class EntidadNoEncontradaException : Exception
    {
        public EntidadNoEncontradaException(string tipo, string identificador)
            :base($"{tipo} con identificador '{identificador}' no encontrado/a.")
        { }
    }
}
