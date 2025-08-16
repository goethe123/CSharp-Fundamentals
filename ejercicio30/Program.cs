using System;
using System.Collections.Generic;
namespace ejercicio39
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ObjetoDelegado Delegado = new ObjetoDelegado(MensajeSaludo.SaludoBienvenida);
            Delegado("soy el goet");

            Delegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);
            Delegado(" fui el goet");

        }

        delegate void ObjetoDelegado(string msj);
    }

    public class MensajeSaludo
    {
        public static void SaludoBienvenida(string msj)
        {
            System.Console.WriteLine("hola hola buenos diías" + msj);
        }
    }

    public class MensajeDespedida
    {
        public static void SaludoDespedida(string msj)
        {
            System.Console.WriteLine("bueno ya me despido muchas gracias"+msj);
        }
    }
}