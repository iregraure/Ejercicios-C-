/* Crea un programa que pida un número y en qué base está expresado.
Debe mostrar el número en el resto de las bases (2, 8, 10, 16) 
Debe seguir pidiendo números hasta que se introduce el 0 */

using System;

public class CambiosDeBase
{
    public static void Main()
    {
        string numIntro;
        int baseNum, num;

        do
        {
            Console.Write("Introduce el número: ");
            numIntro = Console.ReadLine();
            Console.Write("Introduce la base (2, 8, 10, 16): ");
            baseNum = Convert.ToInt32(Console.ReadLine());

            num = Convert.ToInt32(numIntro);

            if (numIntro != "0")
            {
                switch (baseNum)
                {
                    case 2: num = Convert.ToInt32(numIntro, 2);
                            Console.WriteLine("El número binario {0} en octal es {1}", numIntro, Convert.ToString(num, 8));
                            Console.WriteLine("El número binario {0} en decimal es {1}", numIntro, num);
                            Console.WriteLine("El número binario {0} en hexadecimal es {1}", numIntro, Convert.ToString(num, 16));
                            break;
                    case 8: num = Convert.ToInt32(numIntro, 8);
                            Console.WriteLine("El número octal {0} en binario es {1}", numIntro, Convert.ToString(num, 2));
                            Console.WriteLine("El número octal {0} en decimal es {1}", numIntro, num);
                            Console.WriteLine("El número octal {0} en hexadecimal es {1}", numIntro, Convert.ToString(num, 16));
                            break;
                    case 10: Console.WriteLine("El número decimal {0} en binario es {1}", numIntro, Convert.ToString(num, 2));
                            Console.WriteLine("El número decimal {0} en octal es {1}", numIntro, Convert.ToString(num, 8));
                            Console.WriteLine("El número decimal {0} en hexadecimal es {1}", numIntro, Convert.ToString(num, 16));
                            break;
                    case 16: num = Convert.ToInt32(numIntro, 16);
                            Console.WriteLine("El número hexadecimal {0} en binario es {1}", numIntro, Convert.ToString(num, 2));
                            Console.WriteLine("El número hexadecimal {0} en octal es {1}", numIntro, Convert.ToString(num, 8));
                            Console.WriteLine("El número hexadecimal {0} en decimal es {1}", numIntro, num);
                            break;
                    default: Console.WriteLine("La base debe ser 2, 8, 10 o 16");
                            break;
                }
            }
        }
        while (num != 0);
    }
}