using SistEscolar1.DTOs;
using SistEscolar1.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SistEscolar1.Repositorios
{
    public class RepositorioMateriasJSON : IRepositorioMaterias
    {
        private readonly string _path;
        private readonly IRepositorioAlumnos _repoAlumnos;
        private readonly List<Materia> _materias;
        public RepositorioMateriasJSON(string path, IRepositorioAlumnos repoAlumnos)
        {
            _path = path;
            _repoAlumnos = repoAlumnos;
            _materias = Cargar();
        }
        private List<Materia> Cargar()
        {
            if (!File.Exists(_path)) return new List<Materia>();
            string json = File.ReadAllText(_path);
            var dtos = JsonSerializer.Deserialize<List<MateriaDto>>(json) ?? new();
            return dtos.Select(dto =>
            {
                var materia = new Materia(dto.Codigo, dto.Nombre, dto.Cupo);
                foreach (int legajo in dto.LegajosInscriptos)
                {
                    var alumno = _repoAlumnos.BuscarPorLegajo(legajo);
                    if (alumno != null) materia.Inscribir(alumno);
                }
                return materia;
            }).ToList();
        }
        public void Guardar()
        {
            var dtos = _materias.Select(m => new MateriaDto
            {
                Codigo = m.Codigo,
                Nombre = m.Nombre,
                Cupo = m.Cupo,
                LegajosInscriptos = m.devolverInscriptos()
                    .OfType<Alumno>().Select(a => a.Legajo).ToList()
            }).ToList();
            string json = JsonSerializer.Serialize(dtos,
            new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_path, json);
        }
        public void Agregar(Materia m) => _materias.Add(m);
        public Materia? BuscarPorId(string id) => BuscarPorCodigo(id);
        public Materia? BuscarPorCodigo(string c) =>
        _materias.FirstOrDefault(m => m.Codigo == c);
        public List<Materia> ObtenerTodos() => new(_materias);

        public void Eliminar(Materia materia)
        {
            _materias.Remove(materia);
        }
        public Materia BuscarPorCodigos(string codigo)
        {
            throw new NotImplementedException();
        }
    }
}
