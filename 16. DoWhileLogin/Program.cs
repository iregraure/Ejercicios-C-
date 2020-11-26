/* Crea un programa que pida al usuario su identificador y su contraseña, 
y no le permita seguir hasta que introduzca como nombre "Pedro" y como 
contraseña "Peter". */

using System;

public class DoWhileLogin {

    public static void Main() {

        string nombre;
        string pass;

        do{
            Console.Write("Introduce el nombre de usuario: ");
            nombre = Console.ReadLine();
            Console.Write("Introduce la contraseña: ");
            pass = Console.ReadLine();

            if(nombre != "Pedro" || pass != "Peter"){
                Console.WriteLine("Usuario y/o password incorrecto. Intentalo de nuevo");
            }
        }while (nombre != "Pedro" || pass != "Peter");

    }
}