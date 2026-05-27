using SistEscolar1.Excepciones;
using SistEscolar1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Repositorios
{
    public class RepositorioDocentesMemoria : IRepositorioDocentes
    {
        private readonly List<Alumno> _alumnos = new();
        
        public void Guardar() { }
    }
}
