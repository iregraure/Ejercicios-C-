/* Crea un programa que muestre las letras de la Z (mayúscula) a la A 
(mayúscula, descendiendo). */

using System;

public class ContarConLetras {

    public static void Main() {

        char letra;

        for (letra = 'Z'; letra >= 'A'; letra--){
            Console.Write(letra);
        }

    }
}