using System;

public class NumeroPar {

    public static void Main() {

        int num;

        Console.Write("Introduce un número: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0){
            Console.WriteLine("El número es par");
        }

        else{
            Console.WriteLine("El número es impar");
        }

    }
}