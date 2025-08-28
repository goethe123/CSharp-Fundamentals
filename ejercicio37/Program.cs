//romano a int

using System;
using System.Collections.Generic;

namespace ejercicio37
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("añade tu numero romano");
            string Romano = Console.ReadLine().ToUpper();

            int resultado = RomanToInt(Romano);
            System.Console.WriteLine($"tu numero fue {Romano} y su integer es {resultado}");
        }
        public static int RomanToInt(string romano)
        {
            Dictionary<char, int> Valores = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M',1000}
            };

            int Total = 0;

            for (int i = 0; i < romano.Length; i++)
            {
                if (i + 1 < romano.Length && Valores[romano[i]] < Valores[romano[i + 1]])
                {
                    Total = Total - Valores[romano[i]];
                }
                else
                {
                    Total = Total + Valores[romano[i]];
                }
            }
            return Total;
        }
    }
}

