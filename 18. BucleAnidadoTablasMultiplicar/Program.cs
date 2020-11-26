/* Crea un programa que pida dos números y muestre las tablas de multiplicar 
de los números entre esos dos números introducidos ambos incluidos. */

using System;

public class BucleAnidadoTablasMultiplicar {

    public static void Main() {

        int inicial, final, tabla, num, resul;

        Console.Write("Introduce la primera tabla: ");
        inicial = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce la última tabla: ");
        final = Convert.ToInt32(Console.ReadLine());

        if (inicial > final) {
            int aux = inicial;
            inicial = final;
            final = aux;
        }

        for (tabla = inicial; tabla <= final; tabla++){
            Console.WriteLine("TABLA DEL {0}:", tabla);
            for (num = 0; num <= 10; num++){
                resul = tabla * num;
                Console.WriteLine("{0} x {1} = {2}", tabla, num, resul);
            }
            Console.WriteLine("");
        }

    }
}