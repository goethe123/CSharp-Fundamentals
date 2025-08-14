using System;
using System.Collections.Generic;

namespace ejercicio22
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creamos un "almacén" con espacio para 4 elementos
            // Como este almacén guarda 'object', podemos meter cualquier tipo de dato.
            AlmacenObjetos almacen1 = new AlmacenObjetos(4);

            // Ejemplo con strings y enteros (comentado para centrarnos en empleados)
            // almacen1.agregar("uno");
            // almacen1.agregar("dos");
            // almacen1.agregar("tres");
            // almacen1.agregar(4);
            // Console.WriteLine(almacen1.GetElemento(2));

            // Ejemplo usando objetos de tipo empleado
            almacen1.agregar(new empleado(1200));
            almacen1.agregar(new empleado(1300));
            almacen1.agregar(new empleado(1400));
            almacen1.agregar(new empleado(1500));

            // Recuperamos el elemento que está en la posición 2
            // El método devuelve 'object', así que debemos hacer un CAST para volverlo a 'empleado'
            empleado emp1 = (empleado)almacen1.GetElemento(2);

            // Mostramos el salario de ese empleado
            System.Console.WriteLine(emp1.GetSalario());
        }
    }

    // Clase que almacena cualquier tipo de objeto gracias a que usa 'object' (la clase base de todo en C#)
    public class AlmacenObjetos
    {
        private int i = 0; // Posición actual para agregar elementos
        private object[] datosElementos; // Arreglo que guardará los elementos (tipo object para aceptar cualquier cosa)

        // Método para agregar un objeto al almacén
        public void agregar(object objeto)
        {
            datosElementos[i] = objeto; // Guardamos en la posición actual
            i++; // Avanzamos a la siguiente posición
        }

        // Método para obtener un elemento por su posición
        // Retorna 'object' porque no sabemos qué tipo real tiene hasta que lo usemos
        public object GetElemento(int i)
        {
            return datosElementos[i];
        }

        // Constructor que define el tamaño del almacén
        public AlmacenObjetos(int z)
        {
            datosElementos = new object[z]; // Creamos el arreglo con el tamaño que nos pidan
        }
    }

    // Clase 'empleado' que guarda un salario y lo devuelve con GetSalario
    class empleado
    {
        private double salario;

        public empleado(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }
}
//video 60