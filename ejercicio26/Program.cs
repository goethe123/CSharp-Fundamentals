using System;
using System.Collections.Generic;

namespace ejercicio26
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numList = new List<int>();
            Console.WriteLine("añade el elemento que quieres a la collection de tipo lista, 0 pa salir");
            int UserNum = 1;

            while (UserNum != 0)
            {
                UserNum = Convert.ToInt32(Console.ReadLine());

                numList.Add(UserNum);
            }

            System.Console.WriteLine("has salido del programa, estos son los elementos de tu coleccion : ");

            for (int i = 0; i < numList.Count; i++)
            {
                Console.Write(numList[i] +", ");
            }

        }
    }
}