/* Crea un programa que pregunte al usuario cuántos números enteros va a introducir, le pida todos
esos números, los guarde en un array, calcule y muestre su media y finalmente muestre los números 
que estén por encima de la media */

using System;

public class ArrayBasico
{
    public static void Main()
    {
        // Declaración de variables
        int cantidad, num, suma = 0, media;
        int[] numeros;

        // Pedimos la cantidad de números a introducir
        Console.Write("Introduce el número de números que vas a escribir: ");
        cantidad = Convert.ToInt32(Console.ReadLine());

        try
        {
            // Si el número es menor o igual que 0 lanzamos una excepción
            if (cantidad <= 0)
            {
                throw new Exception("El número debe ser mayor que 0");
            }
            // Inicializamos el array
            numeros = new int[cantidad];
            // Utilizamos un bucle for para pedir todos los números, los guarde en el array y los vaya sumando
            for (int i = 0; i < cantidad; i++)
            {
                // Pedimos el número
                Console.Write("Introduce un número: ");
                num = Convert.ToInt32(Console.ReadLine());
                // Guardamos el número en el array
                numeros[i] = num;
                // Sumamos el número a la suma total
                suma += num;
            }
            // Calculamos y mostramos la media de los números
            media = suma / cantidad;
            Console.WriteLine("La media de los números introducidos es {0}", media);
            Console.WriteLine("Los números que están por encima de la media y su posición son: ");
            // Recorremos el array usando un bucle for para mostrar los números superiores a la media
            for (int i = 0; i < cantidad; i++)
            {
                // Guardamos en la variable num el valor que está guradado en la posición i del array
                num = numeros[i];
                // Si num > media lo mostramos junto con su posición
                if (num > media) 
                {
                    Console.WriteLine("Número: {0} - Posición {1}", num, i);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Se ha producido un error: {0}", e.Message);
        }
    }
}