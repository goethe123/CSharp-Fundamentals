using System;
using System.Collections.Generic;

namespace ejercicio36
{
    public class Program
    {
        public static void Main(string[] Args)
        {
            Console.WriteLine("que numero quieres verificar si es palindromo?");
            int numero = Convert.ToInt32(Console.ReadLine());

            string StringNum = numero.ToString();

            char[] Palabra = StringNum.ToCharArray();
            Array.Reverse(Palabra);

            string inverso = new string(Palabra);

            if (inverso == StringNum)
            {
                System.Console.WriteLine(StringNum+ " si es un palindromo");
            }
            else
            {
                System.Console.WriteLine(" no es palindromo");
            }


        }
    }
}