using SistEscolar1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Repositorios
{
    public interface IRepositorioDocentes : IRepositorio<Docente>
    {
        // Búsqueda específica del dominio escolar
        Docente? BuscarPorNumeroDeEmpleado(int noEmpleado);
    }
}
