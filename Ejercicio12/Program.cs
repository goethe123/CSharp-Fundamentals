// Ejercicio práctico de Interfaces en C#
// -----------------------------------------
// Este ejemplo muestra cómo crear interfaces y usarlas en diferentes clases.
// Las interfaces definen un contrato: si una clase las implementa, debe proporcionar
// una implementación para todos sus métodos.

// Importamos librerías necesarias
using System;

namespace Ejercicio12
{
    // Interface: define el contrato para mamíferos terrestres
    public interface IMamiferosTerrestres
    {
        int NumeroPatas(); // Método que devuelve el número de patas
    }

    // Interface: define el contrato para animales que participan en deportes
    public interface IAnimalesYDeportes
    {
        string TipoDeporte(); // Tipo de deporte en el que participa
        bool EsOlimpico();    // Si el deporte es olímpico o no
    }

    // Interface: define el contrato para animales que saltan con patas
    public interface ISaltoConPatas
    {
        int NumeroPatas(); // Similar al anterior, pero para saltadores
    }

    public class Program
    {
        public static void Main(String[] args)
        {

            // Creamos instancias de distintas clases
            Caballo caballo1 = new Caballo("Milica");
            IMamiferosTerrestres Icaballo1 = caballo1;
            Humano humano1 = new Humano("Mitzi");
            Gorila gorila1 = new Gorila("Mili");
            Ballena ballena1 = new Ballena("Willy");

            // Ejemplo de polimorfismo: variable de tipo Mamifero
            Mamifero animal = new Caballo("Pol");

            // Llamamos a métodos de cada instancia
            caballo1.GetNombre();
            humano1.GetNombre();
            gorila1.GetNombre();

            // Creamos un array de mamíferos
            Mamifero[] ArrayMamiferos = new Mamifero[3];
            ArrayMamiferos[0] = caballo1;
            ArrayMamiferos[1] = humano1;
            ArrayMamiferos[2] = gorila1;

            // Ejemplo de polimorfismo dinámico con override
            for (int i = 0; i < 3; i++)
            {
                ArrayMamiferos[i].Pensar();
            }

            // Ballena usa un método propio
            ballena1.Nadar();

            // Ejemplo de uso de un método definido en una interface
            Console.WriteLine(Icaballo1.NumeroPatas());


            Lagartija lagartija1 = new Lagartija("Teodoro");
            lagartija1.Respirar();
            lagartija1.GetNombre();
            Humano Juan = new Humano("Juan");
            Juan.Respirar(); 
            
        }
    }

    public abstract class Animales
    {
        public void Respirar()
        {
            System.Console.WriteLine("soy capaz de respirar");
        }
         public abstract void GetNombre();
    }

    public class Lagartija : Animales
    {
        private string nombreReptil;
        public override void GetNombre()
        {
            Console.WriteLine($"hola soy {nombreReptil}");
        }

        public Lagartija(string nombre)
        {
            nombreReptil = nombre; 
        }
    }

    // Clase base para todos los mamíferos
    public class Mamifero : Animales
    {
        private string NombreSerVivo; // Campo privado con el nombre

        // Método común para todos los mamíferos
        public void CuidarCrias()
        {
            Console.WriteLine("Soy capaz de cuidar mis crías");
        }

        public override void GetNombre()
        {
            Console.WriteLine($"Hola, soy {NombreSerVivo}");
        }

        // Método virtual para que las clases hijas lo sobrescriban
        public virtual void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }

        // Constructor para inicializar el nombre
        public Mamifero(string nombre)
        {
            NombreSerVivo = nombre;
        }
    }

    // Clase Caballo implementa dos interfaces
    public class Caballo : Mamifero, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
    {
        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        public override void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }

        public Caballo(string NombreCaballo) : base(NombreCaballo) { }

        // Implementación del contrato IMamiferosTerrestres
        int IMamiferosTerrestres.NumeroPatas()
        {
            return 4;
        }

        // Implementación del contrato IAnimalesYDeportes
        public string TipoDeporte()
        {
            return "Hípica";
        }

        public bool EsOlimpico()
        {
            return true;
        }
        int ISaltoConPatas.NumeroPatas()
        {
          return  2;
        }
    }

    // Clase Humano hereda de Mamifero, sin interfaces
    public class Humano : Mamifero
    {
        public override void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar avanzadamente");
        }

        public Humano(string NombreHumano) : base(NombreHumano) { }
    }

    // Clase Gorila implementa una interface
    public class Gorila : Mamifero, IMamiferosTerrestres
    {
        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public override void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar un poco más");
        }

        public Gorila(string NombreGorila) : base(NombreGorila) { }

        public int NumeroPatas()
        {
            return 2;
        }
    }

    // Clase Ballena hereda de Mamifero, sin interfaces
    public class Ballena : Mamifero
    {
        public Ballena(string NombreBallena) : base(NombreBallena) { }

        public void Nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
}
