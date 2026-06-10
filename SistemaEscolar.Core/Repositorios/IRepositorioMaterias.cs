using SistEscolar1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistEscolar1.Controller;
using SistEscolar1.View;

namespace SistEscolar1.Repositorios
{
    public interface IRepositorioMaterias : IRepositorio<Materia>
    {
        Materia? BuscarPorCodigos(string codigo);
    }
}
