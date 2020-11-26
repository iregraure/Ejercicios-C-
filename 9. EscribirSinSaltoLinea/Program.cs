using System;

public class EscribirSinSaltoLinea {
    public static void Main() {
        int a, b, operacion1, operacion2;

        Console.Write("Introduce el primer número: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        b = Convert.ToInt32(Console.ReadLine());

        operacion1 = (a + b) * (a - b);
        operacion2 = 2 * a - 2 * b;

        Console.Write("El resultado de la primera operación es ");
        Console.Write(operacion1);
        Console.Write(" y el de la segunda operación es ");
        Console.Write(operacion2);
    }
}