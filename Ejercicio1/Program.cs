using System;
using System.Collections.Generic;
namespace Ejercicio1
{

    // Ejercicio 1: Tabla de multiplicar (Bucles, Métodos)
    // Tema: Métodos, bucles, condicionales
    // Descripción:
    // Crea un método que reciba un número y muestre su tabla de multiplicar del 1 al 10.
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("dame el numero que quieres para multiplicar");
            int numUser = Convert.ToInt32(Console.ReadLine());
            Multiplicación(numUser);
        }

        public static void Multiplicación(int num)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}