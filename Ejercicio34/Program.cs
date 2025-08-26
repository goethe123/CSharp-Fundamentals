using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio34
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ControlEmpresaEmpleado ceos = new ControlEmpresaEmpleado();
            Console.WriteLine("------------CEO EMPLOYEES-------------");
            Console.WriteLine();
            ceos.getCEO();
            Console.WriteLine("------------ABC ORDERED EMPLOYEES-------------");
            Console.WriteLine();
            ceos.OrderEmployees();

            Console.WriteLine("------------GOOGLE EMPLOYEES-------------");
            Console.WriteLine();
            ceos.GetEmpleadosGoogle();

            Console.WriteLine("------------CHOOSE YOUR COMPANY------------");
            Console.WriteLine();
            Console.WriteLine("que compañía quieres elegir? \n 1- Google \n 2- Microsoft \n 3- Epic");
           
            try
            {
                int company = Convert.ToInt32(Console.ReadLine());
                ceos.SelectCompanyEmployees(company);
            }
            catch (Exception ex)
            { 
                Console.WriteLine("ID erroneo mi loco");
            }
        }
    }

    public class ControlEmpresaEmpleado
    {
        List<Empresa> ListaEmpresa;
        List<Empleado> ListaEmpleado;

        public ControlEmpresaEmpleado()
        {
            ListaEmpresa = new List<Empresa>();
            ListaEmpleado = new List<Empleado>();

            ListaEmpresa.Add(new Empresa { ID = 1, Name = "Google" });
            ListaEmpresa.Add(new Empresa { ID = 2, Name = "Microsoft" });
            ListaEmpresa.Add(new Empresa { ID = 3, Name = "EPIC" });

            ListaEmpleado.Add(new Empleado { Name = "Carlos", ID = 1, Cargo = "Developer", EmpresaID = 1, Salario = 5000 });
            ListaEmpleado.Add(new Empleado { Name = "Michael", ID = 2, Cargo = "CEO", EmpresaID = 2, Salario = 54000 });
            ListaEmpleado.Add(new Empleado { Name = "Jim", ID = 3, Cargo = "CEO", EmpresaID = 3, Salario = 52000 });
            ListaEmpleado.Add(new Empleado { Name = "Dwight", ID = 4, Cargo = "Developer", EmpresaID = 1, Salario = 57000 });

        }

        public void getCEO()
        {
            IEnumerable<Empleado> CEOS = from e in ListaEmpleado
                                         where e.Cargo == "CEO"
                                         select e;

            foreach (Empleado employee in CEOS)
            {
                employee.InfoEmpleado();
            }
        }

        public void OrderEmployees()
        {
            IEnumerable<Empleado> Ordenar = from e in ListaEmpleado orderby e.Name select e;

            foreach (Empleado employee in Ordenar)
            {
                employee.InfoEmpleado();
            }

        }

        public void GetEmpleadosGoogle()
        {
            IEnumerable<Empleado> empleados = from empleado in ListaEmpleado
                                              join Empresa in ListaEmpresa on empleado.EmpresaID equals Empresa.ID
                                              where Empresa.Name == "Google"
                                              select empleado;

            foreach (Empleado employee in empleados)
            {
                employee.InfoEmpleado();
            }



        }
        public void SelectCompanyEmployees(int id)
        {
            IEnumerable<Empleado> empleados = from empleado in ListaEmpleado
                                              join Empresa in ListaEmpresa on empleado.EmpresaID equals Empresa.ID
                                              where Empresa.ID == id
                                              select empleado;

            foreach (Empleado employee in empleados)
            {
                employee.InfoEmpleado();
            }



        }



    }

    public class Empresa
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void InfoEmpresa()
        {
            Console.WriteLine($"El ID de la empresa es : {ID} y su nombre es {Name}");
        }
    }

    public class Empleado
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Cargo { get; set; }

        public double Salario { get; set; }

        //FOREIGN KEY
        public int EmpresaID { get; set; }

        public void InfoEmpleado()
        {
            Console.WriteLine($"ID del Empleado: {ID} \n Nombre del Empleado: {Name} \n Cargo: {Cargo} \n Salario {Salario}");
        }
    }
}

//Crea objetos empleado y empresa y luego una clase control para sacar listas de empleados y empresas