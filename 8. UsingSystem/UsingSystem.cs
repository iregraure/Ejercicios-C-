using System;

public class UsingSystem {
    public static void Main() {
        int num1, num2, producto;

        Console.WriteLine("Introduce el primer número");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduce el segundo número");
        num2 = Convert.ToInt32(Console.ReadLine());
        producto = num1 * num2;

        Console.WriteLine("El producto de {0} y {1} es {2}", num1, num2, producto);
    }
}