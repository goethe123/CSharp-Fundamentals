using System;
using System.Collections.Generic;
namespace Ejercicio10
{

    // 5. Overloading de métodos
    // Ejercicio:
    // Crea una clase Calculadora con:
    // Método Sumar(int a, int b).
    // Método Sumar(double a, double b).
    // Método Sumar(int a, int b, int c).
    // En el Main, llama a cada uno con diferentes valores.
    // {
    public class Program
    {
        public static void Main(string[] args)
        {

            Calculadora calculadora1 = new Calculadora();
            Console.WriteLine(calculadora1.Sumar(5, 5));
            Console.WriteLine(calculadora1.Sumar(2.5, 2.3));
            Console.WriteLine(calculadora1.Sumar(5,5,5));



        }
    }

    public class Calculadora
    {
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public double Sumar(double a, double b)
        {
            return a + b;
        }

        public int Sumar(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}