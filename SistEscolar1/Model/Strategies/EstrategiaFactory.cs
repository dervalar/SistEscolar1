using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Model.Strategies
{
    public static class EstrategiaFactory
    {
        public static IStratPromedio Crear(string nombre) => nombre switch
        {
            nameof(PromedioPonderado) => new PromedioPonderado(),
            nameof(PromedioSinExtremo) => new PromedioSinExtremo(),
            _ => new PromedioSimple(), // default
        };
    }
}
