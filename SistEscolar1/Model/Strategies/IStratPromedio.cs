using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Model.Strategies
{
    public interface IStratPromedio
    {
        double Calcular(List<double> notas);
    }
}
