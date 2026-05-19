using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistEscolar1.Model
{
    public abstract class Persona
    {
        public string Nombre { get; private set; }
        
        public string Email {  get; private set; }

        public virtual void Presentarse()
        {
            Console.WriteLine($"[{ObtenerRol()}] {Nombre} — {Email}");
        }

        protected Persona(string nombre, string email)
        {
            Nombre = nombre;
            Email = email;
        }
        public abstract string ObtenerRol();
    }
}
