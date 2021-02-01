using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.Constructor
{
    class PersonaItaliana : Persona
    {
        public PersonaItaliana()
        {

        }

        public new void Saludar()
        {
            Console.WriteLine("Ciao, io sonno " + this.nombre);
        }
    }
}
