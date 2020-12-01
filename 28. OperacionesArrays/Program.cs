/* Crea un programa que tenga un array de enteros positivos de 20 posiciones. 10 de esas posiciones deben contner datos.
Crea un menú que permita:
    1- Mostrar el array
    2- Buscar un dato
    3- Mostrar el valor máximo y mínimo
    4- Mostrar la media de los datos
    5- Añadir un dato al final
    6- Añadir un dato en una posición
    7- Eliminar un dato en una posición
    8- Salir del programa
*/

using System;

public class OperacionesArrays
{
    public static void Main()
    {
        // Constantes
        const int LONGITUD = 20;

        // Variables
        int indice = 10, num, max, min, suma, media, pos, op;
        int[] numeros = { 26, 48, 52, 76, 15, 48, 39, 62, 89, 94, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        bool encontrado;

        try
        {
            // Mostramos el menú mientras que la opción seleccionada sea distinta de 8
            do
            {
                Console.WriteLine("Seleccione una de las siguientes opciones: ");
                Console.WriteLine("1- Mostrar el array");
                Console.WriteLine("2- Buscar un dato");
                Console.WriteLine("3- Mostrar el valor máximo y mínimo");
                Console.WriteLine("4- Mostrar la media de los datos");
                Console.WriteLine("5- Añadir un dato al final");
                Console.WriteLine("6- Añadir un dato en una posición");
                Console.WriteLine("7- Eliminar un dato en una posición");
                Console.WriteLine("8- Salir del programa");
                // Leemos la opción seleccionada
                op = Convert.ToInt32(Console.ReadLine());
                try
                {
                    // Utilizamos un switch para evaluar la opción seleccionada
                    switch (op)
                    {
                        // Mostrar el array
                        case 1:
                            Console.WriteLine("Elementos del array:");
                            // Recorremos el array y mostramos sus elementos
                            for (int i = 0; i < indice; i++)
                            {
                                Console.WriteLine(numeros[i]);
                            }
                            // Añadimos una línea en blanco antes de mostrar el menú
                            Console.WriteLine();
                            break;
                        // Buscar un dato
                        case 2: // Pedimos el dato a buscar al usuario
                            Console.Write("Intoduce el número a buscar: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            // Si el número es negativo o 0 lanzamos una excepción
                            if (num <= 0)
                            {
                                throw new Exception("El número debe ser mayor que 0");
                            }
                            // Inicializamos encontrado a false
                            encontrado = false;
                            // Recorremos el array
                            for (int i = 0; i < indice; i++)
                            {
                                // Si el elemento coincide con el número introducido mostramos su posición
                                if (numeros[i] == num)
                                {
                                    Console.WriteLine("Dato encontrado en la posición {0}", i + 1);
                                    // Cambiamos el valor de encontrado a true
                                    encontrado = true;
                                }
                            }
                            // Si no se ha encontrado mostramos un mensaje
                            if (!encontrado)
                            {
                                Console.WriteLine("No se ha encontrado el dato");
                            }
                            // Añadimos una línea en blanco antes de mostrar el menú
                            Console.WriteLine();
                            break;
                        // Mostrar el valor máximo y mínimo
                        case 3: // Asignamos como valor máximo y mínimo el primer elemento
                            max = numeros[0];
                            min = numeros[0];
                            // Recorremos el array
                            for (int i = 0; i < indice; i++)
                            {
                                // Guardamos el dato en la variable num
                                num = numeros[i];
                                // Si num > max actualizamos el valor de max
                                if (num > max)
                                {
                                    max = num;
                                }
                                // Si num < min actualizamos el valor de min
                                if (num < min)
                                {
                                    min = num;
                                }
                            }
                            // Mostramos los valores maximo y mínimo y una línea en blanco
                            Console.WriteLine("El valor máximo es {0} y el valor mínimo es {1}", max, min);
                            Console.WriteLine();
                            break;
                        // Mostrar la media de los datos
                        case 4: // Inicializamos la variable suma a 0
                            suma = 0;
                            // Recorremos el array y sumamos sus valores
                            for (int i = 0; i < indice; i++)
                            {
                                suma += numeros[i];
                            }
                            // Calculamos la media
                            media = suma / indice;
                            // Mostramos la media y una línea en blanco
                            Console.WriteLine("La media de los números del array es {0}", media);
                            Console.WriteLine();
                            break;
                        // Añadir un dato al final
                        case 5: // Si el indice es igual a la longitud, el array está lleno y no se puden añadir datos
                            if (indice == LONGITUD)
                            {
                                throw new Exception("El array está lleno, elimine algún dato antes de poder insertar nuevos datos");
                            }
                            // Pedimos el dato a insertar
                            Console.Write("Intoduce el número a insertar: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            // Si el número es negativo o 0 lanzamos una excepción
                            if (num <= 0)
                            {
                                throw new Exception("El número debe ser mayor que 0");
                            }
                            // Insertamos el número en la posción que indica el indice
                            numeros[indice] = num;
                            // Sumamos 1 al índice
                            indice++;
                            // Informamos que se ha añadido el número y añadimos una línea en blanco
                            Console.WriteLine("El número se ha añadido correctamente");
                            Console.WriteLine();
                            break;
                        // Añadir un dato en una posición
                        case 6: // Si el indice es igual a la longitud, el array está lleno y no se puden añadir datos
                            if (indice == LONGITUD)
                            {
                                throw new Exception("El array está lleno, elimine algún dato antes de poder insertar nuevos datos");
                            }
                            // Pedimos el dato a insertar
                            Console.Write("Intoduce el número a insertar: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            // Si el número es negativo o 0 lanzamos una excepción
                            if (num <= 0)
                            {
                                throw new Exception("El número debe ser mayor que 0");
                            }
                            // Pedimos la posición
                            Console.Write("Introduce la posición del número (las posiciones empiezan por 0): ");
                            pos = Convert.ToInt32(Console.ReadLine());
                            /* Si se indica una posición superior al númeor de elementos actuales, 
                                insertamos el número en la posción que indica el indice */
                            if (pos > indice)
                            {
                                numeros[indice] = num;
                                // Sumamos uno al índice
                                indice++;
                                // Mostramos un mensaje indicando que se ha añadido el número
                                Console.WriteLine("Elemento insertado al final del array al haber indicado una posición superior al número de elementos actuales");
                            }
                            // Sino, tenemos que mover todos los elementos a la derecha hasta llegar a la posición indicada
                            else
                            {
                                int i = indice;
                                while (i > pos)
                                {
                                    // En la posición i guardamos el elemento que tenemos en la posición anterior
                                    numeros[i] = numeros[i - 1];
                                    // Restamos 1 a i para ir comprobando todas las posiciones posteriores a pos
                                    i--;
                                }
                                // Cuando salimos del bucle solo falta añadir el nuevo dato en la posición indicada
                                numeros[pos] = num;
                                // Sumamos uno al índice
                                indice++;
                                // Mostramos un mensaje indicando que se ha realizado la operación
                                Console.WriteLine("El número se ha introducido correctamente");
                            }
                            // Mostramos una línea en blando
                            Console.WriteLine();
                            break;
                        // Eliminar un dato en una posición
                        case 7: // Pedimos la posición que vamos a eliminar
                            Console.Write("Introduce la posición del número (las posiciones empiezan por 0): ");
                            pos = Convert.ToInt32(Console.ReadLine());
                            // Si la posición es mayor o igual que el índice lanzamos una excepción
                            if(pos >= indice)
                            {
                                throw new Exception ("No hay tantos elementos en el array, introduce una posición menor");
                            }
                            // Restamos 1 al índice
                            indice--;
                            // Recorremos los elementos empezando por la posición indicada. En la posición i guardamos el siguiente elemento
                            // mientras que i sea menor que el indice
                            int j = pos;
                            while (j < indice)
                            {
                                numeros[j] = numeros[j + 1];
                                j++;
                            }
                            // Cuando salimos del bucle solo falta poner un 0 en la posición que indica el indice
                            numeros[indice] = 0;
                            //  Mostramos un mensaje y una línea en blanco
                            Console.WriteLine("Se ha eliminado el elemento de forma correcta");
                            Console.WriteLine();
                            break;
                        // Salir del programa
                        case 8:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Has seleccionado una opción incorrecta");
                            Console.WriteLine();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (op != 8);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}