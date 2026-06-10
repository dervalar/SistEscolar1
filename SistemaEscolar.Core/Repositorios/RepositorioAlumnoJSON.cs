using SistEscolar1.DTOs;
using SistEscolar1.Excepciones;
using SistEscolar1.Model;
using SistEscolar1.Model.Strategies;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SistEscolar1.Repositorios
{
    public class RepositorioAlumnoJSON : IRepositorioAlumnos
    {
        private readonly string _path;
        private readonly List<Alumno> _alumnos;
        public RepositorioAlumnoJSON(string path)
        {
            _path = path;
            _alumnos = Cargar();
        }
        // ── Carga desde disco ─────────────────────────────────────────────
        private List<Alumno> Cargar()
        {
            if (!File.Exists(_path)) return new List<Alumno>();
            string json = File.ReadAllText(_path);
            var dtos = JsonSerializer.Deserialize<List<AlumnoDto>>(json) ?? new();
            return dtos.Select(dto =>
            {
                var alumno = new Alumno(dto.Nombre, dto.Email, dto.Legajo,
                EstrategiaFactory.Crear(dto.Estrategia));
                alumno.CargarNotas(dto.Notas);
                return alumno;
            }).ToList();
        }

        // ── Guarda a disco ────────────────────────────────────────────────
        public void Guardar()
        {
            var dtos = _alumnos.Select(a => new AlumnoDto
            {
                Nombre = a.Nombre,
                Email = a.Email,
                Legajo = a.Legajo,
                Notas = a.ObtenerNotas(),
                Estrategia = a.NombreEstrategia
            }).ToList();
            string json = JsonSerializer.Serialize(dtos,
            new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_path, json);
        }
        // ── Implementación de la interfaz ─────────────────────────────────
        public void Agregar(Alumno a)
        {
            if (BuscarPorLegajo(a.Legajo) != null)
                throw new LegajoYaExisteException(a.Legajo);
            _alumnos.Add(a);
        }
        public Alumno? BuscarPorId(string id) =>
        _alumnos.FirstOrDefault(a => a.Legajo.ToString() == id);
        public Alumno? BuscarPorLegajo(int l) =>
        _alumnos.FirstOrDefault(a => a.Legajo == l);
        public List<Alumno> ObtenerTodos() => new(_alumnos);

        public Docente BuscarPorNumeroDeEmpleado(int noEmpleado)
        {
            throw new NotImplementedException();
        }

        public void Agregar(Docente entidad)
        {
            throw new NotImplementedException();
        }
    }
}
