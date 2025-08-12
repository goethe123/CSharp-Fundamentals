// Ejercicio práctico de Polimorfismo en C#
// -------------------------------------------------
// En este ejemplo creamos tres clases: Vehiculo, Avion y Coche.
// - Vehiculo es la clase base que define métodos comunes como ArrancarMotor y PararMotor.
// - También define un método virtual "Conducir" que puede ser sobrescrito por las clases hijas.
// - Avion y Coche heredan de Vehiculo y sobrescriben el método Conducir con comportamientos propios.
// El objetivo es demostrar cómo funciona el polimorfismo dinámico con virtual/override.

// Importamos los espacios de nombres necesarios
using System;

namespace Ejercicio13
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // Creamos un objeto de tipo Avion
            Avion avion1 = new Avion();

            // Creamos un objeto de tipo Coche
            Coche coche1 = new Coche();

            // Creamos un arreglo de Vehiculo que puede almacenar
            // cualquier objeto que herede de Vehiculo (polimorfismo)
            Vehiculo[] vehiculos = new Vehiculo[2];
            vehiculos[0] = avion1; 
            vehiculos[1] = coche1;


            // ------------------------------
            // Polimorfismo con colecciones
            // ------------------------------
            for (int i = 0; i < vehiculos.Length; i++)
            {
                vehiculos[i].ArrancarMotor(); // Método heredado sin sobrescribir
                vehiculos[i].Conducir();      // Método sobrescrito, ejecuta el correcto según el tipo real
                vehiculos[i].PararMotor();    // Método heredado sin sobrescribir
                Console.WriteLine(); // Salto de línea para separar salidas
            }

            // ------------------------------
            // Polimorfismo con una variable de tipo base
            // ------------------------------
            Vehiculo MiVehiculo = coche1;
            MiVehiculo.Conducir(); // Ejecuta la versión de Coche.Conducir()

            MiVehiculo = avion1;
            MiVehiculo.Conducir(); // Ejecuta la versión de Avion.Conducir()
        }
    }

    // Clase base que representa un vehículo genérico
    public class Vehiculo
    {
        // Método común: no es virtual, todas las clases hijas heredan este comportamiento tal cual
        public void ArrancarMotor()
        {
            Console.WriteLine("Ha arrancado el motor");
        }

        // Método común: no es virtual, comportamiento igual para todos
        public void PararMotor()
        {
            Console.WriteLine("Ha parado el motor");
        }

        // Método virtual: las clases hijas pueden sobrescribirlo para un comportamiento específico
        public virtual void Conducir()
        {
            Console.WriteLine("Empezando a conducir");
        }
    }

    // Clase Avion que hereda de Vehiculo
    public class Avion : Vehiculo
    {
        // Sobrescribimos el método Conducir para adaptarlo a un avión
        public override void Conducir()
        {
            Console.WriteLine("Empezamos a conducir el avión");
        }
    }

    // Clase Coche que hereda de Vehiculo
    public class Coche : Vehiculo
    {
        // Sobrescribimos el método Conducir para adaptarlo a un coche
        public override void Conducir()
        {
            Console.WriteLine("Empezamos a conducir el coche");
        }
    }
}
