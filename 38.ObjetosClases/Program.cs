/*
    Crea una clase llamada Persona. Esta clase deberá tener un atributo "nombre", de tipo string. También deberá tener 
    un método "SetNombre", de tipo void y con un parámetro string, que permita cambiar el valor del nombre. Finalmente, 
    también tendrá un método "Saludar", que escribirá en pantalla "Hola, soy " seguido de su nombre. Crea también una 
    clase llamada PruebaPersona. Esta clase deberá contener sólo la función Main, que creará dos objetos de tipo Persona, 
    les asignará un nombre a cada uno y les pedirá que saluden.
*/

using System;

public class Persona
{
    private string nombre;

    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public void Saludar()
    {
        Console.WriteLine("Hola, soy " + this.nombre);
    }
}

public class PruebaPersona
{
    public static void Main()
    {
        Persona p1 = new Persona();
        Persona p2 = new Persona();

        p1.setNombre("Irene");
        p2.setNombre("Pedro");

        p1.Saludar();
        p2.Saludar();
    }
}