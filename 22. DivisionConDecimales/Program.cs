/* Crea un programa que muestre el resultado de dividir 3 entre 4
usando números enteros y luego usando números en coma flotante */

using System;

public class DivisionConDecimales
{
    public static void Main()
    {
        int int1 = 3;
        int int2 = 4;
        float float1 = 3;
        float float2 = 4;
        float resul;

        resul = int1 / int2;
        Console.WriteLine("El resultado de dividir 3 entre 4 usando enteros es {0}", resul);

        resul = float1 / float2;
        Console.WriteLine("El resultado de dividir 3 entre 4 usando reales es {0}", resul);
    }
}