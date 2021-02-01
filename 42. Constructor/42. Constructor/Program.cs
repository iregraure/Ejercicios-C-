using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.Constructor
{
    /*
     *  Ampliar el proyecto anterior para que todas las clases contengan constructores. Los constructores de casi todas las clases estarán vacíos,
     *  excepto del de PersonaInglesa, que prefijará su nombre a "John". Crea también un constructor alternativo para esta clase que permita escoger 
     *  cualquier otro nombre.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            PersonaInglesa p2 = new PersonaInglesa();
            PersonaInglesa p3 = new PersonaInglesa();
            PersonaItaliana p4 = new PersonaItaliana();

            p1.setNombre("Irene");
            p2.setNombre("Peter");
            p4.setNombre("Bianca");

            p1.Saludar();
            p2.Saludar();
            p2.TomarTe();
            p3.Saludar();
            p3.TomarTe();
            p4.Saludar();

            Console.ReadKey();
        }
    }
}
