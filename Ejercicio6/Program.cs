using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Ejercicio6
{
    public class Program
    {
        public static void Main(string[] args)

        {

            int numero;


            do
            {
                Console.WriteLine("añade un numero mayor a 0");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            while (numero <= 0);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero*i}");
            }
            
            

        }
    }
}

// Ejercicio:
// Crea un programa que pida al usuario un número entero positivo y muestre su tabla de multiplicar del 1 al 10.
// Si el número es negativo o cero, pedir otro hasta que sea válido.
// Usa un while para validar y un for para la tabla.