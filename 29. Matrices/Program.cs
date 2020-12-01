/*
    Crea un programa que pregunte al usuario el tamaño que tendrán dos bloques de números enteros 
    (por ejemplo, uno de 10 elementos y otro de 12). Luego pedirá los datos para ambos bloques de datos. 
    Finalmente deberá mostrar el mayor dato que se ha introducido en cada uno de ellos.
*/

using System;

public class Matrices 
{
    public static void Main()
    {
        // Variables
        int[][] matriz;
        matriz = new int[2][];
        int num1, num2, max1 = 0, max2 = 0;

        // Pedimos las longitudes de los arrays
        Console.Write("Introduce la longitud del primer array: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        // Si es negativo o 0 lanzamos una excepción
        if (num1 <= 0)
        {
            throw new Exception("La longitud debe ser mayor que 0");
        }
        Console.Write("Introduce la longitud del segundo array: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        // Si es negativo o 0 lanzamos una excepción
        if (num2 <= 0)
        {
            throw new Exception("La longitud debe ser mayor que 0");
        }
        // Declaramos los arrays de la matriz
        matriz[0] = new int[num1];
        matriz[1] = new int[num2];

        // Creamos un bucle para pedir los datos de la matriz
        for (int i = 0; i < matriz.Length; i++)
        {
            for (int j = 0; j < matriz[i].Length; j++)
            {
                Console.Write("Introduce el número de la casilla {0} {1}: ", i, j);
                matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Calculamos el máximo del primer array
        for (int i = 0; i < matriz[0].Length; i++)
        {
            if (matriz[0][i] > max1)
            {
                max1 = matriz[0][i];
            }
        }

        // Calculamos el máximo del segundo array
        for (int i = 0; i < matriz[1].Length; i++)
        {
            if (matriz[1][i] > max2)
            {
                max2 = matriz[1][i];
            }
        }

        // Mostramos los resultados
        Console.WriteLine("El número mayor del primer array es {0} y del segundo array es {1}", max1, max2);
    }
}