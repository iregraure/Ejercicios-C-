/*
    Crea un programa que compare utilizando las 3 formas posibles (==, compareTo, String.compare)
*/

using System;

public class CompararCadenas
{
    public static void Main()
    {
        string cadena1, cadena2;

        Console.Write("Introduce la primera cadena: ");
        cadena1 = Console.ReadLine();
        Console.Write("Introduce la segunda cadena: ");
        cadena2 = Console.ReadLine();

        // Utilizando ==
        if (cadena1 == cadena2)
        {
            Console.WriteLine("Las dos cadenas son iguales");
        }
        else
        {
            Console.WriteLine("Las dos cadenas son distintas");
        }

        // Utilizando compareTo
        if (cadena1.CompareTo(cadena2) > 0)
        {
            Console.WriteLine("La primera cadena es mayor que la segunda");
        }
        else if(cadena1.CompareTo(cadena2) < 0)
        {
            Console.WriteLine("La segunda cadena es mayor que la primera");
        }
        else
        {
            Console.WriteLine("Las dos cadenas son iguales");
        }

        // Utilizando String.compare
        Console.Write("Si no tenemos en cuenta las mayúscilas y minúsculas ");
        if (String.Compare(cadena1, cadena2, true) > 0)
        {
            Console.WriteLine("la primera cadena es mayor que la segunda");
        }
        else if(String.Compare(cadena1, cadena2, true) < 0)
        {
            Console.WriteLine("la segunda cadena es mayor que la primera");
        }
        else 
        {
            Console.WriteLine("las dos cadenas son iguales");
        }
    }
}