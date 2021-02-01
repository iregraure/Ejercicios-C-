/*
    Crea un programa que pida al usuario 10 números y los ordene utilizando los 3 métodos disponibles 
    (burbuja, selección directa e inserción directa), mostrando el resultado después de cada ejecución 
    del bucle principal
*/

using System;
using System.Text;

public class Ordenacion
{
    public static void Main()
    {
        int[] datos1 = new int[10], datos2 = new int[10], datos3 = new int[10];
        int num;
        int numDatos = 10;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Introduce un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            datos1[i] = num;
            datos2[i] = num;
            datos3[i] = num;
        }

        // Método burbuja
        Console.Clear();
        Console.WriteLine("ORDENACIÓN MEDIANTE MÉTODO BURBUJA");

        int temp;
        for (int i = 0; i < numDatos - 1; i++)
        {
            Console.Write("Antes de la siguiente vuelta: ");
            muestraArray(datos1);
            for (int j = i + 1; j < numDatos; j++)
            {
                if (datos1[i] > datos1[j])
                {
                    temp = datos1[i];
                    datos1[i] = datos1[j];
                    datos1[j] = temp;
                }
            }
        }

        Console.Write("Array ordenado: ");
        muestraArray(datos1);

        // Selección directa
        Console.WriteLine("ORDENACIÓN MEDIANTE SELECCIÓN DIRECTA");

        int menor, temp2;
        for (int i = 0; i < numDatos - 1; i++)
        {
            Console.Write("Antes de la siguiente vuelta: ");
            muestraArray(datos2);
            menor = i;
            for (int j = i + 1; j < numDatos; j++)
            {
                if (datos2[j] < datos2[menor])
                {
                    menor = j;
                }
            }
            if (menor != i)
            {
                temp2 = datos2[i];
                datos2[i] = datos2[menor];
                datos2[menor] = temp2;
            }
        }

        Console.Write("Array ordenado: ");
        muestraArray(datos2);

        // Inserción directa
        Console.WriteLine("ORDENACIÓN MEDIANTE INSERCIÓN DIRECTA");

        int temp3;
        for (int i = 1; i < numDatos; i++)
        {
            Console.Write("Antes de la siguiente vuelta: ");
            muestraArray(datos3);
            int j = i - 1;
            while ((j >= 0) && (datos3[j] > datos3[j + 1]))
            {
                temp3 = datos3[j];
                datos3[j] = datos3[j + 1];
                datos3[j + 1] = temp3;
                j--;
            }
        }

        Console.Write("Array ordenado: ");
        muestraArray(datos3);
    }

    private static void muestraArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}