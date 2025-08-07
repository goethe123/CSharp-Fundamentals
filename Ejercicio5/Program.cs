using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Tema: Condicionales, bucles, métodos
// Descripción:
// Crea un método que determine si un número es primo o no.
namespace Ejercicio5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("añade un numero para validar si es primo o no");
            int numero = Convert.ToInt32(Console.ReadLine());
            ValidarPrimo(numero);
        }

        public static void ValidarPrimo(int numUser)
        {
            bool EsPrimo = true;
            if (numUser < 2)
            {
                EsPrimo = false;
                Console.WriteLine("nel no es primo");
            }
            else
            {
                for (int i = 2; i < numUser; i++)
                {
                    if (numUser % i == 0)
                    {
                        EsPrimo = false;
                        Console.WriteLine($"nel {numUser} no es primow");
                        break;
                    }
                }
            }
            if (EsPrimo)
            {
                Console.WriteLine("smn el " + numUser + " si es primo ");
            }
        }
    }
}