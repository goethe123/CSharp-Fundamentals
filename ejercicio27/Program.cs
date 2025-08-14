using System;
using System.Collections.Generic;
namespace ejercicio27
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();

            foreach (int numero in new int[5] { 1, 2, 3, 4, 5 })
            {
                numeros.Enqueue(numero);
            }

            System.Console.WriteLine("imprimiendo la cola");

            foreach (int numero in numeros)
            {
                System.Console.WriteLine(numero);
            }

            System.Console.WriteLine("eliminando de la cola");
            numeros.Dequeue();

            foreach (int numero in numeros)
            {
                System.Console.WriteLine(numero);
            }



        }
    }
}