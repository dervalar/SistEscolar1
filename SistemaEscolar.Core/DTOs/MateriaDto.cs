using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.DTOs
{
    public class MateriaDto
    {
        public string Codigo { get; set; } = "";
        public string Nombre { get; set; } = "";
        public int Cupo { get; set; }

        // Solo guardamos los legajos, no los objetos Alumno completos.
        public List<int> LegajosInscriptos { get; set; } = new();
    }
}
