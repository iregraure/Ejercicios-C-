/*
    Crea un programa que pida una cadena al usuario y la modifique, de modo que las letras de las posiciones
    impares estén en minúsculas, y las de las posiciones pares estén en mayúsculas, mostrando el resultado 
    en pantalla.
*/

using System;
using System.Text;

public class StringBuilders
{
    public static void Main()
    {
        StringBuilder cadena;

        Console.Write("Introduce una cadena: ");
        cadena = new StringBuilder(Console.ReadLine());

        for(int i = 0; i < cadena.Length; i++)
        {
            if(i % 2 == 0)
            {
                cadena[i] = cadena[i].ToString().ToUpper()[0];
            }
            else
            {
                cadena[i] = cadena[i].ToString().ToLower()[0];
            }
        }

        Console.WriteLine(cadena.ToString());
    }
}