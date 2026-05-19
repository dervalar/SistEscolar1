using SistEscolar1.Excepciones;
using SistEscolar1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Repositorios
{
    public class RepositorioAlumnosMemoria : IRepositorioAlumnos
    {
        private readonly List<Alumno> _alumnos = new();
        public void Agregar(Alumno alumno)
        {
            if (BuscarPorLegajo(alumno.Legajo) != null)
                throw new LegajoYaExisteException(alumno.Legajo);
            _alumnos.Add(alumno);
        }
        public Alumno? BuscarPorId(string id) =>
        _alumnos.FirstOrDefault(a => a.Legajo.ToString() == id);
        public Alumno? BuscarPorLegajo(int legajo) =>
        _alumnos.FirstOrDefault(a => a.Legajo == legajo);
        public List<Alumno> ObtenerTodos() => new(_alumnos);
        // En memoria no necesitamos persistir nada
        public void Guardar() { }
    }
}
