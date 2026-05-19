using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Model
{
    internal class EscolarModel
    {

        public List<Persona> Personas { get; } = new List<Persona>();
        public List<Materia> Materias { get; } = new List<Materia>();
        public void AgregarPersona(Persona p) => Personas.Add(p);
        public void AgregarMateria(Materia m) => Materias.Add(m);
        public Alumno BuscarAlumnoPorLegajo(int legajo)
        {
            foreach (var p in Personas)
                if (p is Alumno a && a.Legajo == legajo) return a;
            return null;
        }
        public Materia BuscarMateriaPorCodigo(string codigo)
        {
            foreach (var m in Materias)
                if (m.Codigo == codigo) return m;
            return null;
        }

    }
}
