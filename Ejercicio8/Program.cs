// 3. Methods
// Ejercicio:
// Crea un método EsPrimo(int numero) que devuelva true si el número es primo y false si no.
// En el Main, pide un número y usa el método para mostrar el resultado.

using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace Ejercicio8
{
    public class Ejercicio8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Dame un numero entero pa ver si es primo");
            int numero = Convert.ToInt32(Console.ReadLine());

            ValidarPrimo(numero);
        }

        public static void ValidarPrimo(int numUser)
        {
            bool primo = true;

            if (numUser < 2)
            {
                Console.WriteLine("tu numero no es primo ");
                primo = false;
            }
            for (int i = 2; i < numUser; i++)
            {
                if (numUser % i == 0)
                {
                    primo = false;
                }
            }
            if (primo)
            {
                Console.WriteLine($"smn, tu numero {numUser} si es primo");
            }
            else
            {
                Console.WriteLine($"neeel tu numero {numUser} no es primo");
            }
        }
    }
}