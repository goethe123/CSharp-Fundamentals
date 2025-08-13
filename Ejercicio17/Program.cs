
// Contar vocales en una cadena
// Pide al usuario una palabra y devuelve cuántas vocales tiene.
// Tema: string, bucles, condicionales

using System;
using System.Collections.Generic;
namespace ejercicio17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("dame una palabra para contar sus vocales");
            string palabra = Console.ReadLine();
            int vocales = 0;
            string minuscula = palabra.ToLower();
            foreach (char letra in minuscula)
            {
                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'u' || letra == 'o')
                {
                    vocales++;
                }
            }
            Console.WriteLine("tu palabra " + palabra + " tiene " + vocales + " vocales");
        }
     }
}