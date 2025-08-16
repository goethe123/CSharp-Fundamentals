using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection.Metadata;

namespace ejercicio32
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            Persona p1 = new Persona();
            p1.Edad = 21;
            p1.Nombre = "Juan";

            Persona p2 = new Persona();
            p2.Edad = 25;
            p2.Nombre = "Pepe";

            Persona p3 = new Persona();
            p3.Edad = 21;
            p3.Nombre = "Gomez";

            personas.AddRange(new Persona[] { p1, p2, p3 });

            Predicate<Persona> Predicado = new Predicate<Persona>(ExisteJuan);
            bool ExisteJuanes = personas.Exists(ExisteJuan);

            if (ExisteJuanes)
            {
                System.Console.WriteLine("si hay juanes en tu lista de personas");
            }
            else
            {
                System.Console.WriteLine("no hay juanes en tu lista");
            }

        }

        public static bool ExisteJuan(Persona persona)
        {
            if (persona.Nombre == "Juan")
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }

    public class Persona
    {
        private int edad;
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; } 
        
        public int Edad { get => edad; set => edad = value; }



    }
}