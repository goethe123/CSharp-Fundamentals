using System;
using System.Collections.Generic;
namespace ejercicio26
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("cuantos elementos quieres añadir?");
            int numeros = Convert.ToInt32(Console.ReadLine());

            List<int> NumsList = new List<int>();

            for (int i = 0; i < numeros; i++)
            {
                System.Console.WriteLine("añade el elemento de la posicion " + i);
                NumsList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < numeros; i++)
            {
                Console.Write(NumsList[i]);
            }
            
        }
    }
}
