/* Calcula el área de un círculo, dado su radio, que será un número entero
(área = pi * radio al cuadrado) */

using System;

public class CalculaAreaCirculo
{
    public static void Main() 
    {
        const float PI = 3.1416f;
        int radio;
        float area;

        Console.Write("Introduce el radio del círculo: ");
        radio = Convert.ToInt32(Console.ReadLine());
        area = PI * radio * radio;

        Console.WriteLine("El área de un círculo con radio {0} es {1}", radio, area);
    }
}