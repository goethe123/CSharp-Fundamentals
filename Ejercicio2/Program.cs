using System;
using System.Collections.Generic;
namespace Ejercicio2
{
    // Tema: Clases, instanciación, getters y setters, constructores
    // Descripción:
    // Crea una clase Persona con los atributos: Nombre, Edad, Ciudad.
    //  Agrega un constructor y métodos GetNombre(), SetEdad(), etc.
    public class Program
    {
        public static void Main(string[] args)
        {
            Persona persona1 = new Persona("Carlitos", 19, "Canada");
            Console.WriteLine($"Nombre: {persona1.GetNombre()}\nEdad: {persona1.GetEdad()}\nCiudad {persona1.GetCiudad()}");

            persona1.SetEdad(20);
            persona1.SetCiudad("Guadalajara");
            Console.WriteLine("Despues de modificar: ");
            Console.WriteLine($"Nombre: {persona1.GetNombre()}\n Edad: {persona1.GetEdad()}\n Ciudad {persona1.GetCiudad()}");
        }
    }
    public class Persona
    {
        private string nombre;
        private int edad;
        private string ciudad;

        

        //contstructor
        public Persona(string Nombre, int Edad, string Ciudad)
        {
            nombre = Nombre;
            edad = Edad;
            ciudad = Ciudad;
        }

        //Getters 

        public string GetNombre()
        {
            return nombre;
        }

        public int GetEdad()
        {
            return edad;
        }

        public string GetCiudad()
        {
            return ciudad;
        }

        //SETTERS

        public void SetNombre(string NuevoNombre)
        {
            nombre = NuevoNombre;
        }

        public void SetEdad(int NuevaEdad)
        {
            edad = NuevaEdad;
        }

        public void SetCiudad(string NuevaCiudad)
        {
            ciudad = NuevaCiudad;
        }
    }

}