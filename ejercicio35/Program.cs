// Dado un arreglo de enteros nums y un número entero target, devuelve los índices de los dos números tales que su suma sea igual a target.
// Puedes suponer que cada entrada tendrá exactamente una única solución, y no puedes usar el mismo elemento dos veces.

// Example 1:
// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].



using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
namespace ejercicio35
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int[] numeros = new int[] { 3,2,4};
            int Target = 6;
            List<int> sumados = new List<int>();

            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[i] + numeros[j] == Target)
                    {
                        sumados.Add(i);
                        sumados.Add(j);
                        i = numeros.Length;
                        break;
                    }
                }
            }
            System.Console.WriteLine($"tu array contiene: ");
            foreach (int n in numeros)
            {
                Console.Write(n + ", ");
            }
            System.Console.WriteLine("\n");
            System.Console.WriteLine($"y los indices que dan igual a {Target} son los indices : ");
            
            foreach (int n in sumados)
            {
                Console.Write($"{n}, ");

            }

            }
        }
    }
