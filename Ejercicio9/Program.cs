using System;
using System.Collections.Generic;

// 4. Constructores y POO
// Ejercicio:
// Crea una clase Persona con: DONE
// Propiedades: Nombre, Edad, Ciudad. DONE
// Constructor que inicialice las tres propiedades. 
// Método Presentarse() que muestre un mensaje con los datos de la persona.
// En el Main, crea 3 objetos Persona y llama a Presentarse().

namespace Ejercicio9
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Persona persona1 = new Persona("Ana", 20, "New York");
            Console.WriteLine(persona1.Presentarse());
            Persona persona2 = new Persona("jimmy", 23, "metropolis");
            Console.WriteLine(persona2.Presentarse());
            Persona persona3 = new Persona("clark", 33, "Kansas");
            Console.WriteLine(persona3.Presentarse());

        }
    }

    public class Persona
    {
        private string nombre;
        private int edad;
        private string ciudad;

        public Persona(string Nombre, int Edad, string Ciudad)
        {
            nombre = Nombre;
            edad = Edad;
            ciudad = Ciudad;
        }

        public string Presentarse()
        {
            return $"mi nombre es {nombre}, tengo {edad} y soy de {ciudad}";
        }
    }
}
