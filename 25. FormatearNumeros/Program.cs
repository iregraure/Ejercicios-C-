/* Crea un programa que pida un número decimal y lo muestre con distintos 
formatos usando los códigos de formatos */

using System;

public class FormatearNumeros
{
    public static void Main() 
    {
        double numero;

        Console.Write("Introduce el número a formatear: ");
        numero = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(numero.ToString("N1"));
        Console.WriteLine(numero.ToString("N3"));
        Console.WriteLine(numero.ToString("0.0"));
        Console.WriteLine(numero.ToString("0.0000"));
        Console.WriteLine(numero.ToString("#.#"));
        Console.WriteLine(numero.ToString("#.#####"));
    }
}