/*
    Crea un programa que genere 1000 úmeros aleatorios, los guarde en un array y los ordene.
    una vez ordenados obtendrá un nuevo número aleatorio y lo buscará utilizando la búsqueda binaria
    e informará al usuario de si lo encuentra o no.
*/

using System;
using System.Threading;

public class BusquedaBinaria
{
    public static void Main()
    {
        const int n = 1000;
        int[] datos = new int[n];
        int i;

        // Generar los datos
        Console.WriteLine("Generando números aleatorios...");
        Random r = new Random();
        for (i = 0; i < n; i++)
        {
            datos[i] = r.Next(1, n*2);
        }
        Thread.Sleep(1000);

        // Ordenar los datos
        Console.WriteLine("Ordenando los números...");
        ordenaArray(datos, n);
        Thread.Sleep(1000);
        
        // Obtener número aleatorio a buscar
        int aleatorio = r.Next(1, n*2);

        Console.WriteLine("Buscando si aparece el número " + aleatorio + "...");
        Thread.Sleep(1000);
        int limInf = 0;
        int limSup = n - 1;
        bool terminado = false;

        while (!terminado)
        {
            int puntoMedio = limInf + (limSup - limInf) / 2;
            Console.WriteLine("Buscando entre la posicion " + limInf + " con valor " + datos[limInf] + " y la posición " + limSup + " con valor " + datos[limSup]);
            if(datos[puntoMedio] == aleatorio)
            {
                Console.WriteLine("Encontrado!");
                terminado = true;
            }
            else if(limInf == limSup - 1)
            {
                Console.WriteLine("No encontrado...");
                terminado = true;
            }
            else
            {
                if(datos[puntoMedio] < aleatorio)
                {
                    limInf = puntoMedio;
                }
                else
                {
                    limSup = puntoMedio;
                }
            }
        }
    }

    private static void ordenaArray(int[] array, int numDatos)
    {
        int temp;
        for (int i = 0; i < numDatos - 1; i++)
        {
            for (int j = i + 1; j < numDatos; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
    }
}