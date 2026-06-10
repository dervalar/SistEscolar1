using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Core.Model.Observer
{
    /* Contrato que debe cumplir cualquier clase que quiera
       tener observadores suscritos.*/
    internal interface ISujetoEscolar
    {
        void Suscribir(IObservadorEscolar observador);
        void Desuscribir(IObservadorEscolar observador);
        void Notificar(CambioEscolar cambio, object dato);
    }
}
