using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Model.Strategies
{
    public class PromedioSinExtremo : IStratPromedio
    {
        public double Calcular(List<double> notas)
        {
            if (notas.Count <= 2) return new PromedioSimple().Calcular(notas);
            var copia = new List<double>(notas);
            copia.Sort();
            copia.RemoveAt(0); // quitar la mínima
            copia.RemoveAt(copia.Count - 1); // quitar la máxima
            return new PromedioSimple().Calcular(copia);
        }

    }
}
