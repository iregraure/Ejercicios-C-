public class SumaPorTeclado {
    public static void Main() {
        int num1;
        int num2;
        int suma;

        System.Console.WriteLine("Introduce el primer número");
        num1 = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine("Introduce el segundo número");
        num2 = System.Convert.ToInt32(System.Console.ReadLine());
        suma = num1 + num2;

        System.Console.WriteLine("La suma de {0} y {1} es {2}", num1, num2, suma);
    }
}