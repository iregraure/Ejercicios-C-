using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.ProyectoVariosFicherosFunete
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            Persona p2 = new Persona();

            p1.setNombre("Irene");
            p2.setNombre("Pedro");

            p1.Saludar();
            p2.Saludar();

            Console.ReadKey();
        }
    }
}
