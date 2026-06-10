using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Model.Strategies
{
    public class PromedioPonderado : IStratPromedio
    {
        public double Calcular(List<double> notas)
        {
            if (notas.Count == 0) return 0;
            double sumaPeso = 0;
            double totalPeso = 0;
            for (int i = 0; i < notas.Count; i++)
            {
                int peso = i + 1;
                sumaPeso += notas[i] * peso;
                totalPeso += peso;
            }

            return sumaPeso / totalPeso;

        }
    }
}
