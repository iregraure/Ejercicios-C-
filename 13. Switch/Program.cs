using System;

public class Switch {
    public static void Main() {

        char letra;

        Console.Write("Introduce una letra: ");
        letra = Convert.ToChar(Console.ReadLine());

        switch (letra){
            case '.':
            case ',':
            case ':':
            case ';': Console.WriteLine("Ha introducido un signo de puntuación");
                    break;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9': Console.WriteLine("Ha introducido un número");
                    break;
            default: Console.WriteLine("Ha introducido otro tipo de carácter");
                    break;
        }
    }
}