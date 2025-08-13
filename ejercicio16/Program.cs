// Ejercicios sin properties (campos y métodos)
// Ejercicio 1 – Clase CuentaBancaria
// Campos privados: titular, saldo.
// Métodos GetTitular(), SetTitular(string), GetSaldo(), Depositar(decimal), Retirar(decimal).
// En Main, crea una cuenta y prueba depositar y retirar.
// Ejercicio 2 – Clase Vehiculo
// Campos privados: marca, modelo, velocidadMaxima.
// Métodos para leer y modificar cada campo.
// Valida que velocidadMaxima no pueda ser negativa.

using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
namespace ejercicio16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CuentaBancaria MiCuenta = new CuentaBancaria("miki");
            MiCuenta.Depositar(1300);
            System.Console.WriteLine(MiCuenta.GetSaldo());

            //2

            Estudiante Gabo = new Estudiante("Gabo");
            Console.WriteLine(Gabo.NOMBRE);
            Gabo.NOMBRE = "toto";
            Console.WriteLine(Gabo.NOMBRE);
            Gabo.CALIFICACION = 11;
            Console.WriteLine(Gabo.CALIFICACION);

        }
    }

    public class CuentaBancaria
    {
        private string titular;
        private double saldo;

        public string GetTitular()
        {
            return titular;
        }

        public void SetTitular(string NombreTitular)
        {
            titular = NombreTitular;
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public void Depositar(double Saldillo)
        {
            saldo += Saldillo;
        }

        public void Retirar(double Retiro)
        {
            saldo -= Retiro;
        }

        public CuentaBancaria(string titular)
        {
            this.titular = titular;
        }
    }
}
// Ejercicio 3 – Clase Estudiante
// Campos privados: nombre, calificacion.
// Properties: Nombre (simple), Calificacion (solo acepta valores de 0 a 10).
// En Main, crea varios estudiantes y muestra sus datos.
public class Estudiante
{
    private string nombre;
    private double califciacion;

    public string NOMBRE
    {
        get { return "el nombre del estudiante es " + nombre; }
        set { nombre = value; }
    }
    public double CALIFICACION
    {
        get { return califciacion; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("la calificacion no puede ser menor a 0");
                califciacion = 0;


            }
            else if (value > 10)
            {
                System.Console.WriteLine("la calificacion no debe ser mayor a 10");
                califciacion = 10;
            }
            else
            {
                califciacion = value;
            }
        }
    }
    public Estudiante(string Nombre)
    {
        nombre = Nombre;
    }


   
}