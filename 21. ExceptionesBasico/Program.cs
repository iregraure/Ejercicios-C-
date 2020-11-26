/* Crea un programa que pregunte al usuario su edad y su año de nacimiento. 
Si la edad que introduce no es un número válido, mostrará un mensaje de 
aviso. Lo mismo ocurrirá si el año de nacimiento no es un número válido. */

using System;

public class ExcepcionesBasico {

    public static void Main() {

        int edad, anio;

        try {
            Console.Write("Introduce tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad < 0) {
                throw new Exception("La edad debe ser mayor que 0");
            }
            else {
                Console.Write("Introduce tu año de nacimiento: ");
                anio = Convert.ToInt32(Console.ReadLine());
                if (anio < 0){
                    throw new Exception ("El año debe ser mayor que 0");
                }
            }
        }
        catch (Exception e){
            Console.WriteLine("Se ha producido un error: {0}", e.Message);
        }

    }
}