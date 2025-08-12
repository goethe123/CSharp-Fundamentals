using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(String[] args)
    {

        Caballo caballo1 = new Caballo("milica");
        Humano humano1 = new Humano("mitzi");
        Gorila gorila1 = new Gorila("mili");

        Mamifero animal = new Caballo("pol");

        caballo1.GetNombre();
        humano1.GetNombre();
        gorila1.GetNombre();


        Mamifero[] ArrayMamiferos = new Mamifero[3];

        ArrayMamiferos[0] = caballo1;
        ArrayMamiferos[1] = humano1;
        ArrayMamiferos[2] = gorila1;

        for (int i = 0; i < 3; i++)
        {
            ArrayMamiferos[i].Pensar();
        }

        


    }
}

public class Mamifero
{
    private string NombreSerVivo;


    public void CuidarCrias()
    {
        Console.WriteLine("soy caapaz de cuidar mis crias");
    }

    public void Respirar()
    {
        Console.WriteLine("soy capaz de respirar");
    }

    public void GetNombre()
    {
        Console.WriteLine($"hola soy {NombreSerVivo}");
    }

    public void respirar()
    {
        System.Console.WriteLine("soy capaz de pensar");
    }

    public virtual void Pensar()
    {
        Console.WriteLine("soy capaz de pensar");
    }

    public Mamifero(string nombre)
    {
        NombreSerVivo = nombre;
    }
    

}

public class Caballo : Mamifero
{
    public void Galopar()
    {
        Console.WriteLine("soy capaz de galopar ");
    }

    public override void Pensar()
    {
        System.Console.WriteLine("soy capaz de penzar");
    }

    public Caballo(string NombreCaballo)
    : base(NombreCaballo)
    {

    }
}


public class Humano : Mamifero
{
    public override void Pensar()
    {
        Console.WriteLine("soy capaz de pensar avanzadamente");
    }

    public Humano(string NombreHumano)
    : base(NombreHumano)
    {

    }
}

public class Gorila : Mamifero
{
    public void Trepar()
    {
        Console.WriteLine("Soy capac de trepar");
    }

    public override void Pensar()
    {
        System.Console.WriteLine("soy capaz de penza un poco másr");
    }

    public Gorila(string NombreGorila)
    : base(NombreGorila)
    {

    }
}