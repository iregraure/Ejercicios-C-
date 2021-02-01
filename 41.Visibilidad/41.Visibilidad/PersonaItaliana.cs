using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.Visibilidad
{
    class PersonaItaliana : Persona
    {
        public new void Saludar()
        {
            Console.WriteLine("Ciao, io sonno " + this.nombre);
        }
    }
}
