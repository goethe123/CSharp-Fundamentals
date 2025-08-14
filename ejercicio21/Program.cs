using System;

namespace ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado antonio = new Empleado(Bonus.normal, 20000);
            antonio.MostrarInfo();

            Empleado michel = new Empleado(Bonus.extra, 1500);
            michel.MostrarInfo();
        }
    }

    public class Empleado
    {
        private double bonus;
        private double salario;

        public Empleado(Bonus bonusEmpleado, double salario)
        {
            bonus = (double)bonusEmpleado;
            this.salario = salario;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Salario base: {salario}");
            Console.WriteLine($"Bonus: {bonus}");
            Console.WriteLine($"Total: {salario + bonus}");
        }

        
    }

   public enum Bonus { bajo = 500, normal = 1000, bueno = 1500, extra = 3000 };
}
