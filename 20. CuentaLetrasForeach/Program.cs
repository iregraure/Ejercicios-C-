/* Crea un programa que cuente cuantas veces aparece la letra 'a' en una 
frase que teclee el usuario, utilizando "foreach". */

using System;

public class CuentaLetrasForeach {

    public static void Main() {
        
        string frase;
        int numLetras = 0;

        Console.Write("Escribe una frase: ");
        frase = Console.ReadLine();

        foreach (char letra in frase) {
            if (letra == 'a') {
                numLetras++;
            }
        }

        Console.WriteLine("En la frase {0} hay {1} letras 'a'", frase, numLetras);
    }
}