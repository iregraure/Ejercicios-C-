/* 
    Crea un programa que pida al usuario una frase y muestre sus palabras en orden inverso
*/

using System;

public class DescomponerCadenasEnFragmentos
{
    static void Main()
    {
        string frase;

        Console.Write("Escribe una frase: ");
        frase = Console.ReadLine();

        string[] palabrasFrase = frase.Split(" ");

        for(int i = palabrasFrase.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(palabrasFrase[i]);
        }
    }
}

