/*
    Crea una función que reciba una cadena con el nombre y primer apellido de una persona y devuelva sus iniciales
    usando parámetros por referencia. Crea un main que permita comprobar que funciona correctamente.
*/

using System;

public class ParametrosSalida
{
    public static void Main()
    {
        string nombre, iniciales1 = "", iniciales2;

        Console.Write("Introduce tu nombre y primer apellido: ");
        nombre = Console.ReadLine();

        Iniciales1(nombre, ref iniciales1);
        Iniciales2(nombre, out iniciales2);

        Console.WriteLine("Usando valor por referencia las iniciales son: " + iniciales1);
        Console.WriteLine("Usando parámetro de salida las iniciales son: " + iniciales2);
    }

    private static void Iniciales1 (string nombre, ref string iniciales1)
    {
        string[] partes = nombre.Split(" ");
        iniciales1 = partes[0][0].ToString() + partes[1][0].ToString();
    }

    private static void Iniciales2 (string nombre, out string iniciales2)
    {
        string[] partes = nombre.Split(" ");
        iniciales2 = partes[0][0].ToString() + partes[1][0].ToString();
    }
}