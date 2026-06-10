using SistEscolar1.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistEscolar1.Model
{
    public class EscolarModel
    {
        private readonly IRepositorioAlumnos _repoAlumnos;
        private readonly IRepositorioMaterias _repoMaterias;
        private readonly IRepositorioDocentes _repoDocentes;

        // Los repositorios se inyectan desde Program.cs
        public EscolarModel(IRepositorioAlumnos repoAlumnos, IRepositorioMaterias repoMaterias, IRepositorioDocentes repoDocentes)
        {
            _repoAlumnos = repoAlumnos;
            _repoMaterias = repoMaterias;
            _repoDocentes = repoDocentes;
        }
        public void AgregarAlumno(Alumno a) => _repoAlumnos.Agregar(a);
        public void AgregarMateria(Materia m) => _repoMaterias.Agregar(m);
        public void AgregarDocente(Docente d) => _repoDocentes.Agregar(d);
        public List<Alumno> ObtenerAlumnos() => _repoAlumnos.ObtenerTodos();
        public List<Docente> ObtenerDocente() => _repoDocentes.ObtenerTodos();
        public List<Materia> ObtenerMaterias() => _repoMaterias.ObtenerTodos();
        public Alumno? BuscarAlumno(int legajo) => _repoAlumnos.BuscarPorLegajo(legajo);
        public Docente? BuscarDocente(int noEmpleado) => _repoDocentes.BuscarPorNumeroDeEmpleado(noEmpleado);
        public Materia? BuscarMateria(string codigo) => _repoMaterias.BuscarPorCodigos(codigo);

        // Llama a Guardar() en todos los repositorios.
        // En memoria no hace nada; en JSON guarda los archivos.
        public void GuardarTodo()
        {
            _repoAlumnos.Guardar();
            _repoMaterias.Guardar();
            _repoDocentes.Guardar();
        }
        //Método que uné las listas
        public List<Persona> ObtenerPersonas()
        {
            List<Persona> todas = new List<Persona>();
            todas.AddRange(_repoAlumnos.ObtenerTodos());
            todas.AddRange(_repoDocentes.ObtenerTodos());
            return todas;
        }

    }
}
