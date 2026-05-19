using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.DTOs
{
    // DTO: solo datos, sin lógica, para serialización/deserialización.
    public class AlumnoDto
    {
        public string Nombre { get; set; } = "";
        public string Email { get; set; } = "";
        public int Legajo { get; set; }
        public List<double> Notas { get; set; } = new();

        // Guardamos el nombre de la estrategia como string para reconstruirla
        public string Estrategia { get; set; } = "Simple";
    }
}
