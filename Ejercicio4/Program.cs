using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
// Tema: Clases, Constructores, Listas, Bucles
// Descripción:
// Crea una clase Producto con Nombre, Precio, Stock. Luego crea una lista de productos (puedes usar List<Producto>)
// y muestra los productos cuyo stock sea menor a 5.
namespace Ejercicio4
{
    public class Constants
    {
        public static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>
            {
                new Producto ("Usb", 15, 90),
                new Producto("macbook", 2000, 100),
                new Producto("ipad", 1000, 12)
            };

            foreach (Producto prod in productos)
            {
                if (prod.stock < 20)
                {
                    Console.WriteLine($"Producto: {prod.nombre}, Precio {prod.precio}, Stock: {prod.stock}");
                }          
            }
        }
    }

    public class Producto
    {
        public string nombre { get; set; }
        public int precio { get; set; }
        public int stock { get; set; }

        //constructor

        public Producto (string Nombre, int Precio, int Stock)
        {
            nombre = Nombre;
            precio = Precio;
            stock = Stock;  
        }

    }


}