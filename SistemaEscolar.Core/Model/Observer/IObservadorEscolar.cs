using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Core.Model.Observer
{
    /* Contrato que deben cumplir todos los que quieran
     recibir notificaciones del sistema. */
    public interface IObservadorEscolar
    {
        // cambio: qué ocurrió
        // dato: el objeto afectado (puede ser un Alumno, una Materia, etc.)
        void Actualizar(CambioEscolar cambio, object dato);
    }
}
