using SistEscolar1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistEscolar1.Repositorios
{
    public interface IRepositorioMaterias : IRepositorio<Materia>
    {
        Materia? BuscarPorCodigos(string codigo);
    }
}
