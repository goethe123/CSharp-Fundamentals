using System;
using System.Collections.Generic;
namespace ejercicio28
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();

            foreach (int numero in new int[5] { 1, 2, 3, 4, 5 })
            {
                numeros.Push(numero);
            }

            System.Console.WriteLine("imprimiendo la pila");

            foreach (int numero in numeros)
            {
                System.Console.WriteLine(numero);
            }

            System.Console.WriteLine("eliminando de la pila");
            numeros.Pop();

            foreach (int numero in numeros)
            {
                System.Console.WriteLine(numero);
            }



        }
    }
}