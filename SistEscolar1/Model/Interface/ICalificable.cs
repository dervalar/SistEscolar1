using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Model.Interface
{
    public interface ICalificable
    {
        void AgregarNota(double nota);
        double ObtenerPromedio();
    }
}
