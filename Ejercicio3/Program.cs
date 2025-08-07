using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace Ejercicio3
{
    // Ejercicio 3: Calculadora con Sobrecarga de Métodos
    // Tema: Method Overloading
    // Descripción:
    // Crea una clase Calculadora que tenga varios métodos Sumar(), uno para sumar dos enteros, otro para tres, y otro para decimales.
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculadora calculadora1 = new Calculadora();
            Console.WriteLine("Cuantos enteros quieres sumar? \n 2, 3 o 4 para sumar doubles");
            int enteros = Convert.ToInt32(Console.ReadLine());
            switch (enteros)
            {
                case 2:
                    Console.WriteLine("añade el primer numero");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("\nañade el segundo numero");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(calculadora1.sum(num1, num2));
                    break;

                case 3:
                    Console.WriteLine("añade el primer numero");
                    int numP = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("\nañade el segundo numero");
                    int numS = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nañade el tercer numero");
                    int numT = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(calculadora1.sum(numP, numS, numT));
                    break;

                case 4:
                 Console.WriteLine("añade el primer numero");
                    double DoubleNumber1 = Convert.ToDouble(Console.ReadLine());
                     Console.WriteLine("\nañade el segundo numero");
                    double DoubleNumber2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(calculadora1.sum(DoubleNumber1, DoubleNumber2));
                    
                    break;

            }
        }
        public class Calculadora
        {
            public int sum(int a, int b)
            {
                return a + b;
            }

            public int sum(int a, int b, int c)
            {
                return a + b + c;
            }
            
             public double sum(double a, double b )
            {
                return a + b;
            }
        }
    }
}
