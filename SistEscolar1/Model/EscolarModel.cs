using SistEscolar1.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistEscolar1.Controller;
using SistEscolar1.View;


namespace SistEscolar1.Model
{
    public class EscolarModel
    {
        private readonly IRepositorioAlumnos _repoAlumnos;
        private readonly IRepositorioMaterias _repoMaterias;

        // Los repositorios se inyectan desde Program.cs
        public EscolarModel(IRepositorioAlumnos repoAlumnos,
        IRepositorioMaterias repoMaterias)
        {
            _repoAlumnos = repoAlumnos;
            _repoMaterias = repoMaterias;
        }
        public void AgregarAlumno(Alumno a) => _repoAlumnos.Agregar(a);
        public void AgregarMateria(Materia m) => _repoMaterias.Agregar(m);
        public List<Alumno> ObtenerAlumnos() => _repoAlumnos.ObtenerTodos();
        public List<Materia> ObtenerMaterias() => _repoMaterias.ObtenerTodos();
        public Alumno? BuscarAlumno(int legajo) =>
        _repoAlumnos.BuscarPorLegajo(legajo);
        public Materia? BuscarMateria(string codigo) =>
        _repoMaterias.BuscarPorCodigos(codigo);

        // Llama a Guardar() en todos los repositorios.
        // En memoria no hace nada; en JSON guarda los archivos.
        public void GuardarTodo()
        {
            _repoAlumnos.Guardar();
            _repoMaterias.Guardar();
        }

    }
}
