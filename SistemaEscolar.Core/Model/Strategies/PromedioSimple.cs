using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Model.Strategies
{
    public class PromedioSimple : IStratPromedio
    {
        public double Calcular(List<double> notas)
        {
            if (notas.Count == 0) return 0;
            double suma = 0;
            foreach (var n in notas) suma += n;
            return suma / notas.Count;
        }



    }
}
