using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Core.Model.Observer
{
    // Describe qué tipo de cambio ocurrió en el sistema.
    // Cada valor representa un evento de negocio.
    public enum CambioEscolar
    {
        AlumnoAgregado,
        DocenteAgregado,
        MateriaAgregada,
        AlumnoInscripto,
        NotaCargada,
        EstrategiaCambiada,
        AlumnoEliminado,
    }
}
