using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.Visibilidad
{
    /*
     *  Crea un nuevo proyecto con las siguientes características: La clase Persona no cambia; la clase PersonaInglesa se modificará 
     *  para que redefina el método "Saludar", para que escriba en pantalla "Hi, I am " seguido de su nombre; se creará una nueva clase
     *  PersonaItaliana, en el fichero "personaItaliana.cs", que deberá heredar las características de la clase "Persona", pero redefinir
     *  el método "Saludar", para que escriba en pantalla "Ciao"; crea también una clase llamada PruebaPersona3, en el fichero 
     *  "pruebaPersona3.cs", que deberá contener sólo la función Main y creará un objeto de tipo Persona, dos de tipo PersonaInglesa, uno 
     *  de tipo PersonaItaliana, les asignará un nombre, les pedirá que saluden y pedirá a la persona inglesa que tome té.
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
            p3.setNombre("Claire");
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
