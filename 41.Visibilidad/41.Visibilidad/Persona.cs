using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.Visibilidad
{
    class Persona
    {
        protected string nombre;

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
