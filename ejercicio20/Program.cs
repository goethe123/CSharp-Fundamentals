using System;
using System.Collections.Generic;
namespace ejercicio29
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Empleado gus = new Empleado(1200, 250);
            gus.CambiarSalarioBase(gus, 100);
            System.Console.WriteLine(gus);

        }
    }

    public class Empleado
    {
        public double salarioBase, comision;

        public Empleado(double salarioBase, double comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }
        public override string ToString()
        {
            return string.Format("el salario base de este empleado es {0} y su comision es de {1}", salarioBase, comision);
        }

        public void CambiarSalarioBase(Empleado emp, double incremento)
        {
            emp.salarioBase += incremento;
            emp.comision += incremento;
        }

    }
    
}