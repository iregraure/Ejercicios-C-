/* 
    Crea un programa que pida al usuario una frase y la descomponga en subcadenas separadas por espacios.
    Luego debe mostrar cada subcadena en una línea nueva usando foreach
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

        foreach (string palabra in palabrasFrase)
        {
            Console.WriteLine(palabra);
        }
    }
}
