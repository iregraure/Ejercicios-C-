/* Crea un programa que muestre los números del 100 al 200 (ambos incluidos) 
que sean divisibles entre 7 y a la vez entre 3. */

using System;

public class MuestraNumerosFor {

    public static void Main() {

        int i;

        Console.WriteLine("Números múltiplos de 3 y 7 entre 100 y 200:");
        for(i = 100; i <= 200; i++){
            if ((i % 3 == 0) && (i % 7 == 0)){
                Console.WriteLine(i);
            }
        }

    }
}