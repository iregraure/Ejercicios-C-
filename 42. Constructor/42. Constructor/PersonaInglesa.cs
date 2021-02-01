using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.Constructor
{
    class PersonaInglesa : Persona
    {
        public PersonaInglesa()
        {
            this.nombre = "John";
        }

        public PersonaInglesa(string nombre)
        {
            this.nombre = nombre;
        }

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
