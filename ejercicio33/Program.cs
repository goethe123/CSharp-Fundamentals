using System;
using System.Collections.Generic;
namespace ejercicio33
{
        public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Numeros Pares");
            int[] Numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /*
            List <int> NumerosPares = new List <int> ();

            foreach (int i in Numeros)
            {
                if (i %2 ==0)
                {
                    NumerosPares.Add (i);
                }
            }
            */
            IEnumerable <int> NumerosPares = from numero in Numeros where numero %2 == 0 select numero;

            foreach (int i in NumerosPares)
            {
                Console.Write(i+ ",");
            }
            
        }
    }

    
}