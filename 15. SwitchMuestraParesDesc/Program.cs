/* Crea un programa que escriba en pantalla los números pares del 26 al 10 
(descendiendo), usando "while". */

using System;

public class SwitchMuestraParesDesc {

    public static void Main() {

        Console.WriteLine("Los números pares entre 26 y 10 son:");
        int num = 26;

        while (num >= 10) {
            if(num % 2 == 0) {
                Console.WriteLine(num);
            }
            num--;
        }
        
    }
}