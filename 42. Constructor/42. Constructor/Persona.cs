using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.Constructor
{
    class Persona
    {
        protected string nombre;

        public Persona()
        {

        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, soy " + this.nombre);
        }
    }
}
