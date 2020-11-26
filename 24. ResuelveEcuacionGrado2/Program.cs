/* Halla las soluciones de una ecuación de segundo grado del tipo
y = ax2 + bx + c */

using System;

public class ResuelveEcuacionGrado2 
{
    public static void Main() 
    {
        float a, b, c, resulPos, resulNeg;

        // Pedimos los datos
        Console.Write("Introduce el valor de la variable a: ");
        a = Convert.ToSingle(Console.ReadLine());
        Console.Write("Introduce el valor de la variable b: ");
        b = Convert.ToSingle(Console.ReadLine());
        Console.Write("Introduce el valor de la variable c: ");
        c = Convert.ToSingle(Console.ReadLine());

        // Calculamos los resultados
        resulPos = (float)((-b) + (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);
        resulNeg = (float)((-b) - (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);

        // Mostramos los resultados
        Console.WriteLine("Los resultados de la ecuación {0}x2 + {1}x + {2} son {3} y {4}", a, b, c, resulPos, resulNeg);
    }
}