/* Crea un "calculador de cuadrados": pedirá al usuario un número y mostrará su cuadrado. Se repetirá 
mientras el número introducido no sea cero (usa "while" para conseguirlo). */

using System;

public class SwitchCalculaCuadrado {

    public static void Main(){

        int num, cuadrado;

        Console.Write("Introduce un número: ");
        num = Convert.ToInt32(Console.ReadLine());

        while (num != 0) {
            cuadrado = num * num;
            Console.WriteLine("El cuadrado de {0} es {1}", num, cuadrado);

            Console.Write("Introduce un número: ");
            num = Convert.ToInt32(Console.ReadLine());
        }

    }
}