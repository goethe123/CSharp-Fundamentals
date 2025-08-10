using System;
using System.Collections.Generic;
namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CuentaBancaria MiCuenta = new CuentaBancaria("Goethe", 50);
            

            int Operation = 0;
            do
            {
                Console.WriteLine("que quiers hacer? \n1-  Depositar \n2- Retirar \n3- salir");
                Operation = Convert.ToInt32(Console.ReadLine());
                switch (Operation)
                {
                    case 1:
                        Console.WriteLine("cuanto quieres depositar a tu cuenta?");
                        int Deposito = Convert.ToInt32(Console.ReadLine());
                        MiCuenta.Depositar(Deposito);
                        Console.WriteLine(MiCuenta.MostrarSaldo());
                        break;

                    case 2:
                        Console.WriteLine("cuanto quieres retirar de tu cuenta?");
                        int Retiro = Convert.ToInt32(Console.ReadLine());
                        MiCuenta.Retirar(Retiro);
                        Console.WriteLine(MiCuenta.MostrarSaldo());
                        break;

                    case 3:
                        Console.WriteLine("bye bye");
                        break;
                }
            }
            while (Operation != 3);

        }
    }

    public class CuentaBancaria
    {
        private string titular;
        private double saldo;

        public CuentaBancaria(String Titular, double Saldo)
        {
            titular = Titular;
            saldo = Saldo;
        }

        public void Depositar(double monto)
        {
            saldo += monto;
        }

        public void Retirar(double monto)
        {
            saldo -= monto;
        }

        public string MostrarSaldo()
        {
            return $"tu saldo es de : {saldo}";
        }
    }
}

// 7. Ejercicio integral (todo junto)
// Ejercicio:
// Crea una clase CuentaBancaria con:
// Propiedades: Titular, Saldo.
// Constructor para inicializar la cuenta.
// Métodos:
// Depositar(double monto)
// Retirar(double monto) → No permitir que el saldo quede negativo.
// MostrarSaldo()
// En el Main:
// Crear una cuenta.
// Permitir al usuario elegir entre depositar, retirar o salir (usar un bucle do-while).
// Mostrar el saldo después de cada operación.
