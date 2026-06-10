using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Excepciones
{
    public class SinCupoException : Exception
    {
        public SinCupoException(string nombreMateria)
        : base($"La materia '{nombreMateria}' no tiene cupo disponible.") { }
        
    }
}
