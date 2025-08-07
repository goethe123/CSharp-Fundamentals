using System;
using System.Collecions.Generic;
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
            Persona persona1 = new Persona();
        }
    }
    public class Persona
    {
        private string nombre;
        private int edad;
        private string ciudad;

        public

        //contstructor
        public Persona(string Nombre, int Edad, string Ciudad)
        {
            nombre = Nombre;
            edad = Edad;
            ciudad = Ciudad;
        }

        //Getters 

        public GetNombre()
        {
            return Nombre;
        }

        public GetEdad()
        {
            return Edad;
        }

        public GetCiudad()
        {
            return Ciudad;
        }

        //SETTERS

        public void SetNombre(string NuevoNombre)
        {
            Nombre = NuevoNombre;
        }

        public void SetEdad(int NuevaEdad)
        {
            Edad = NuevaEdad;
        }

        public void SetCiudad(string NuevaCiudad)
        {
            Ciudad = NuevaCiudad;
        }
    }

}