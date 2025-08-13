using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
namespace ejercicio15
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Empleado Pepe = new Empleado("Pepe");
            Pepe.SALARIO = 1200;
            Console.WriteLine("el salario del empleado es " + Pepe.SALARIO);
        }

    }

    public class Empleado
    {
        private double salario;
        private string nombre;

        //creacion de propiedad 

        // public double SALARIO
        // {
        //     get { return this.salario; }
        //     set { this.salario = EvaluarSalario(value); }

        // }
        public double SALARIO
        {
            get => this.salario;
            set => EvaluarSalario(value);
        }

        public double EvaluarSalario(double salario)
        {
            if (salario < 0)
            {
                System.Console.WriteLine(" el salario  no puede ser menor a 0");
                return 0;
            }
            else
            {

                return salario;
            }
        }


        public Empleado(string Nombre)
        {
            nombre = Nombre;
        }

        // public double GetSalario()
        // {
        //     return salario;
        // }

        // public void SetSalario(double Salario)
        // {
        //     if (Salario < 0)
        //     {
        //         Console.WriteLine("el salario del empleado no puede ser mneor a 0 ");
        //         salario = 0;
        //     }
        //     else
        //     {
        //         salario = Salario;
        //     }
        // }

    }
}