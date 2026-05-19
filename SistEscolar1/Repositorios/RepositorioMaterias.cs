using SistEscolar1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Repositorios
{
    public class RepositorioMaterias : IRepositorioMaterias
    {
        private readonly List<Materia> _materias = new();
        public void Agregar(Materia m) => _materias.Add(m);
        public Materia? BuscarPorId(string id) => BuscarPorCodigo(id);
        public Materia? BuscarPorCodigo(string codigo) =>
        _materias.FirstOrDefault(m => m.Codigo == codigo);
        public List<Materia> ObtenerTodos() => new(_materias);
        public void Guardar() { }
    }
}
