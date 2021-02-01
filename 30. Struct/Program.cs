/*
    Crea un struct que almacene datos de una canción en formato mp3
        - Artista
        - Título
        - Duración (en segundos)
        - Tamaño del fichero (en Kb)
        - Imagen
    La imágen de la canción va a ser un struct con los siguientes elementos
        - Nombre
        - Ancho (en pixeles)
        - Alto (en pixeles)
        - Tamaño (en Kb)
    Crea un programa que pueda almacenar hasta 100 canciones y un menú con las siguientes opciones:
        1- Añadir una nueva canción
        2- Mostrar el titulo y artista de todas las canciones
        3- Mostrar los títulos de las canciones cuya imágen tenga un tamaño mayor al indicado por el usuario
        4- Salir del programa
*/

using System;

public class Structs
{
    struct imagen
    {
        public string nombre;
        public int ancho;
        public int alto;
        public int tamanio;
    }

    struct cancion
    {
        public string artista;
        public string titulo;
        public int duracion;
        public int tamanio;
        public imagen imagen;
    }

    public static void Main()
    {
        // Variables
        int op, numCanciones = 0, numCancionesMostradas, tamanioImagen;
        cancion cancion = new cancion();
        imagen imagen = new imagen();
        cancion[] canciones = new cancion[100];

        try
        {
            // Mostramos el menú mientras que la opción seleccionada sea distinta de 4
            do
            {
                Console.WriteLine("Seleccione una de las siguientes opciones: ");
                Console.WriteLine("1. Añadir una nueva cancion");
                Console.WriteLine("2. Mostrar el título y el artista de todas las canciones");
                Console.WriteLine("3. Mostrar los títulos de las canciones cuya imágen tenga un tamaño mayor al indicado por el usuario");
                Console.WriteLine("4. Salir del programa");
                // Leemos la opción seleccionada
                op = Convert.ToInt32(Console.ReadLine());
                try
                {
                    // Utilizamos un switch para evaluar la opción seleccionada
                    switch (op)
                    {
                        // Añadir una canncion
                        case 1:
                            Console.Clear();
                            // Reseteamos los valores de las variables imagen y cancion
                            resetStructs(cancion, imagen);
                            // Pedimos y guardamos todos los datos de la canción
                            Console.Write("Introduce el artista: ");
                            cancion.artista = Console.ReadLine();
                            Console.Write("Introduce el título de la canción: ");
                            cancion.titulo = Console.ReadLine();
                            Console.Write("Introduce la duración de la canción: ");
                            cancion.duracion = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduce el tamaño de la canción: ");
                            cancion.tamanio = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduce el nombre de la imagen: ");
                            imagen.nombre = Console.ReadLine();
                            Console.Write("Introduce el ancho de la imagen: ");
                            imagen.ancho = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduce el alto de la imagen: ");
                            imagen.alto = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Introduce el tamaño de la imagen: ");
                            imagen.tamanio = Convert.ToInt32(Console.ReadLine());
                            cancion.imagen = imagen;
                            // Guardamos la canción en la lista de canciones
                            canciones[numCanciones] = cancion;
                            numCanciones++;
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        // Mostrar titulo y artista de todas las canciones
                        case 2:
                            Console.Clear();
                            if (numCanciones != 0)
                            {
                                for (int i = 0; i < numCanciones; i++)
                                {
                                    Console.WriteLine("- Canción: {0} \t Artista: {1}", cancion.titulo, cancion.artista);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay guardada ninguna canción");
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        // Mostrar canciones cuando tamanioImagen > indicado por usuario
                        case 3:
                            Console.Clear();
                            if (numCanciones != 0)
                            {
                                Console.Write("Introduce el tamaño de la imagen: ");
                                tamanioImagen = Convert.ToInt32(Console.ReadLine());
                                numCancionesMostradas = 0;
                                for (int i = 0; i < numCanciones; i++)
                                {
                                    if(cancion.imagen.tamanio > tamanioImagen)
                                    {
                                        Console.WriteLine("- Canción: {0} \t Artista: {1}", cancion.titulo, cancion.artista);
                                        numCancionesMostradas++;
                                    }
                                }
                                if(numCancionesMostradas == 0)
                                {
                                    Console.WriteLine("No hay ninguna cancion cuya imagen tenga un tamaño superior a {0}", tamanioImagen);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay guardada ninguna canción");
                            }
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        // Salir del programa
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Saliendo del programa...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        // Opción incorrecta
                        default:
                            Console.Clear();
                            Console.WriteLine("Ha seleccionado una opción incorrecta");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (op != 4);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void resetStructs(cancion cancion, imagen imagen)
    {
        imagen.nombre = null;
        imagen.ancho = 0;
        imagen.alto = 0;
        imagen.tamanio = 0;
        cancion.artista = null;
        cancion.titulo = null;
        cancion.duracion = 0;
        cancion.tamanio = 0;
        cancion.imagen = imagen;
    }

}