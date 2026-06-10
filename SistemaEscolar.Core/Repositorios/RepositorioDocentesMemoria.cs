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
        private readonly List<Docente> _docentes = new();

        public void Agregar(Docente docente)
        {
            _docentes.Add(docente);
        }

        public Docente? BuscarPorId(string id) =>
            _docentes.FirstOrDefault(d => d.NoEmpleado.ToString() == id);

        public Docente? BuscarPorNumeroDeEmpleado(int noEmpleado) =>
            _docentes.FirstOrDefault(d => d.NoEmpleado == noEmpleado);

        public List<Docente> ObtenerTodos() => new(_docentes);

        public void Guardar() { }
    }
}
