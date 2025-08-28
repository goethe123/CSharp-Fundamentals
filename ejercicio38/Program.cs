
// Write a function to find the longest common prefix string amongst an array of strings.
// If there is no common prefix, return an empty string "".
// Example 1:
// Input: strs = ["flower","flow","flight"]
// Output: "fl"

using System;
using System.Collections.Generic;
namespace ejercicio38
{
    public class Program
    {
        public static void Main(String[] args)
        {
            string[] ArrayPalabras = new string[] { "troka", "tronar", "trono" };
            System.Console.WriteLine("tu array es : ");
            foreach (string palabra in ArrayPalabras)
            {
                System.Console.Write(palabra + ",");
            }
            System.Console.WriteLine("y tu common prefix es "+ Validar(ArrayPalabras));
           

        }

        public static string Validar(string[] Arraysillo)
        {
            string prefix = Arraysillo[0];
            for (int i = 1; i < Arraysillo.Length; i++)
            {
                while (Arraysillo[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "")
                    {
                        return "";
                    }
                }
            }
            return prefix;
        }
    }
}