using System;
using System.Collections.Generic;
namespace ejercicio19
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] Array = new int[5]{1,2,3,4,5};
            foreach (int numero in Array)
            {
                Console.Write(numero);
                
            }
            Console.WriteLine();

            for (int i = Array.Length - 1; i >= 0; i--)
            {
                Console.Write(Array[i]);
            }

        }
    }
}


// Invertir un arreglo
// Dado un arreglo de enteros, invierte el orden sin usar métodos predefinidos como Array.Reverse().
// Tema: arrays, bucles.