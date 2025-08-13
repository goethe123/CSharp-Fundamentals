using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
namespace ejercicio18
{
    public class Program
    {
        public static void Main(String[] args)
        {
            System.Console.WriteLine("dame una palabra");
            string palabra = Console.ReadLine();

            int Longitud = palabra.Length;
            char[] letras = new char[Longitud];
            int contador = 0;
            for (int i = Longitud - 1; i >= 0; i--)
            {
                letras[contador] = palabra[i];
                contador++;
            }

            Console.Write(letras);
            

        }
    }
}