using System;
using System.Collections.Generic;
namespace ejercicio14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AvisosTrafico aviso1 = new AvisosTrafico();
            AvisosTrafico aviso2 = new AvisosTrafico("Jefatura provincial de no se que", "exceso de velocidad mi cabro", "23-08-2025");

            aviso1.mostrarAvisos();
            System.Console.WriteLine(aviso2.getFeha());
            aviso2.mostrarAvisos();


        }
    }
}