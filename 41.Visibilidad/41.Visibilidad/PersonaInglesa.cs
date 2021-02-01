using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.Visibilidad
{
    class PersonaInglesa : Persona
    {
        public void TomarTe()
        {
            Console.WriteLine("Estoy tomando té");
        }

        public new void Saludar()
        {
            Console.WriteLine("Hi, I am " + this.nombre);
        }
    }
}
