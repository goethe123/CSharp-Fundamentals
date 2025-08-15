using System;
using System.Collections.Generic;

namespace ejercicio29
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> Edades = new Dictionary<string, int>();

            //rellenar nuestra dictionary collection

            //llenar dictionary usando el .Add
            Edades.Add("Juan", 18);
            Edades.Add("Pepe", 28);

            //llenar dictionary como s fuera un array
            Edades["Lopez"] = 20;
            Edades["jacobo"] = 37;

            foreach (KeyValuePair<string, int> persona in Edades)
            {
                Console.WriteLine($"nombre : {persona.Key} \n edad : {persona.Value} \n"); 
            }
        }
    }
}