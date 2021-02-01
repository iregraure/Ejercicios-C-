using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.Herencia
{
    /* 
     * Crea una nueva clase PersonaInglesa, en el fichero "personaInglesa.cs". Esta clase deberá heredar las características de la clase "Persona", 
     * y añadir un método "TomarTe", de tipo void, que escribirá en pantalla "Estoy tomando té". Crear también una clase llamada PruebaPersona2, 
     * en el fichero "pruebaPersona2.cs". Esta clase deberá contener sólo la función Main, que creará dos objetos de tipo Persona y uno de tipo 
     * PersonaInglesa, les asignará un nombre, les pedirá que saluden y pedirá a la persona inglesa que tome té.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            Persona p2 = new Persona();
            PersonaInglesa p3 = new PersonaInglesa();

            p1.setNombre("Irene");
            p2.setNombre("Pedro");
            p3.setNombre("Claire");

            p1.Saludar();
            p2.Saludar();
            p3.Saludar();

            p3.TomarTe();

            Console.ReadKey();
        }
    }
}
