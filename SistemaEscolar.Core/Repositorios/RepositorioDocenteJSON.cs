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
    public class RepositorioDocenteJSON : IRepositorioDocentes
    {
        private readonly string _path;
        private readonly List<Docente> _alumnos;
        public RepositorioDocenteJSON(string path)
        {
            _path = path;
            _alumnos = Cargar();
        }
        // ── Carga desde disco ─────────────────────────────────────────────
        private List<Docente> Cargar()
        {
            if (!File.Exists(_path)) return new List<Docente>();
            string json = File.ReadAllText(_path);
            var dtos = JsonSerializer.Deserialize<List<DocenteDto>>(json) ?? new();
            return dtos.Select(dto =>
            {
                var alumno = new Docente(dto.Nombre, dto.Email, dto.NEmpleado);

                return alumno;
            }).ToList();
        }

        // ── Guarda a disco ────────────────────────────────────────────────
        public void Guardar()
        {
            var dtos = _alumnos.Select(a => new DocenteDto
            {
                Nombre = a.Nombre,
                Email = a.Email,
                NEmpleado = a.NoEmpleado
            }).ToList();
            string json = JsonSerializer.Serialize(dtos,
            new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_path, json);
        }
        // ── Implementación de la interfaz ─────────────────────────────────
        public void Agregar(Docente a)
        {
            if (BuscarPorNumeroDeEmpleado(a.NoEmpleado) != null)
                throw new LegajoYaExisteException(a.NoEmpleado);
            _alumnos.Add(a);
        }
        public Docente? BuscarPorNumeroDeEmpleado(int noEmpleado) =>
        _alumnos.FirstOrDefault(a => a.NoEmpleado == noEmpleado);
        
        public List<Docente> ObtenerTodos() => new(_alumnos);

        public Alumno BuscarPorLegajo(int legajo)
        {
            throw new NotImplementedException();
        }

        public void Agregar(Alumno entidad)
        {
            throw new NotImplementedException();
        }

        public Alumno BuscarPorId(string id)
        {
            throw new NotImplementedException();
        }

        Docente IRepositorio<Docente>.BuscarPorId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
