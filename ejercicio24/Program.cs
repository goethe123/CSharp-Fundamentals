using System;
using System.Collections.Generic;
namespace ejercicio24
{
    interface IEmpleados
    {
        double GetSalario();
    }
    public class Program
    {
        public static void Main(String[] args)
        {
            AlmacenEmpleados<Secretaria> empleados = new AlmacenEmpleados<Secretaria>(3);
            empleados.Agregar(new Secretaria(1000));
            empleados.Agregar(new Secretaria(1100));
            empleados.Agregar(new Secretaria(1200));

            Console.WriteLine(empleados.GetElemento(2).GetSalario());           
        }
    }
    class AlmacenEmpleados<T> where T : IEmpleados
    {
        private int i = 0;
        private T[] datosEmpleado;

        public void Agregar(T obj)
        {
            datosEmpleado[i] = obj;
            i++;
        }

        public T GetElemento(int i)
        {
            return datosEmpleado[i];
        }

        public AlmacenEmpleados(int z)
        {
            datosEmpleado = new T[z];
        }


    }

    public class Director : IEmpleados
    {
        private double salario;
        public Director(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }

    public class Secretaria:IEmpleados
    {
        private double salario;
        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }

    }

    public class Electricista:IEmpleados
    {
        private double salario;
        public Electricista(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }
}