using System;
using System.Collections.Generic;

namespace ejercicio7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numeros = new int[10];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("añade un entero al array en la posición " + i);
                int num = Convert.ToInt32(Console.ReadLine());
                numeros[i] = num;
            }

            // Usa un foreach para recorrerlo.
            foreach (int numbs in numeros)
            {
                Console.WriteLine(numbs);
            }

            // Muestra la suma de todos los elementos.
            int suma = 0;
            foreach (int nums in numeros)
            {
                suma += nums;
            }
            Console.WriteLine("la suma de todos los numeros del array es " + suma);

        // Muestra el valor máximo y mínimo del arreglo.
            int mayor = numeros[0];
            int menor = numeros[0];

            foreach (int num in numeros)
            {
                if (num > mayor)
                {
                    mayor = num;
                }
                if (num < menor)
                {
                    menor = num;
                }
            }
            Console.WriteLine($"el numero mayor del array es {mayor}");
            Console.WriteLine($"el numero menor del array es {menor}");
        }
    }
}

// 2. Arrays
// Ejercicio:
// Declara un arreglo de 10 enteros y permite al usuario llenarlo con números.
// Luego:
// Muestra la suma de todos los elementos.
// Muestra el valor máximo y mínimo del arreglo.
// Usa un foreach para recorrerlo.