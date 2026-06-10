using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Repositorios
{
    // Contrato genérico para cualquier repositorio del sistema.
    // T es el tipo de entidad que maneja (Alumno, Materia, etc.)
    public interface IRepositorio<T>
    {
        void Agregar(T entidad);
        void Eliminar(T entidad);
        T? BuscarPorId(string id);
        List<T> ObtenerTodos();
        void Guardar(); // Persiste los cambios. Puede ser un no-op en memoria.
    }
}
