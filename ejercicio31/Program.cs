// using System;
// using System.Collections.Generic;
// namespace ejercicio31
// {
//     public class Program
//     {
//         public static void Main(String[] args)
//         {

//             List<int> listanumeros = new List<int>();
//             listanumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
//             Predicate<int> ElDelegado = new Predicate<int>(DameLosPrimos);
//             List<int> LosPares = listanumeros.FindAll(ElDelegado);
//             foreach (int i in LosPares)
//             {
//                 Console.WriteLine(i);
//             }


//         }

//         public static bool DameLosPrimos(int num)
//         {
//             if (num % 2 == 0)
//             {
//                 return true;
//             }
//             else
//             {
//                 return false;
//             }
//         }
//     }
// }


// //crea una lista
// // luego llenala
// //luego el delegate
// //luego  haz una lista donde le metas los resultados de ese delegate

//------------------------------------------------------------------

//ahora crea el metodo pa ver si son primos

using System;
using System.Collections.Generic;
namespace ejercicio31
{
    public class Program
    {
        public static void Main(String[] args)
        {
            List<int> Numeros = new List<int>();
            Numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            Predicate<int> predicate = new Predicate<int>(EsPrimo);
            List<int> NumsPrimos = Numeros.FindAll(predicate);
            foreach (int i in NumsPrimos)
            {
                Console.WriteLine(i);
            }

        }

        public static bool EsPrimo(int num)
        {
            bool esprimo = true;
            if (num < 2)
            {
                return false;
            }

            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}