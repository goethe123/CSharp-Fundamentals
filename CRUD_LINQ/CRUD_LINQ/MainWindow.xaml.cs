using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CRUD_LINQ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        DataClasses1DataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["CRUD_LINQ.Properties.Settings.CrudLinqSql"].ConnectionString;

            dataContext = new DataClasses1DataContext(miConexion);

            //  InsertarEmpresa();

            InsertarEmpleado();

            InsertarCargos();
        }

        public void InsertarEmpresa()
        {
            dataContext.ExecuteCommand("DELETE FROM EMPRESA");


            Empresa Pildoras = new Empresa();

            Pildoras.Nombre = "Pildoras Informaticas";

            dataContext.Empresas.InsertOnSubmit(Pildoras);

            Empresa GOOGLE = new Empresa();

            GOOGLE.Nombre = "Google";

            dataContext.Empresas.InsertOnSubmit(GOOGLE);

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.Empresas;
        }

       public void  InsertarEmpleado ()
        {
            dataContext.ExecuteCommand("DELETE FROM EMPLEADO");

            Empresa Pildoras = dataContext.Empresas.First(Em => Em.Nombre.Equals("Pildoras Informaticas"));
            Empresa GOOGLE = dataContext.Empresas.First(Em => Em.Nombre.Equals("Google"));

            List<Empleado> listaEmpleados = new List<Empleado>();
            listaEmpleados.Add(new Empleado { Nombre = "Rafael", Apellido ="Quintero",EmpresaId =GOOGLE.Id});

            listaEmpleados.Add(new Empleado { Nombre = "Neto", Apellido = "Fonseca", EmpresaId = Pildoras.Id });

            listaEmpleados.Add(new Empleado { Nombre = "Amado", Apellido = "Carrillo", EmpresaId = GOOGLE.Id });

            listaEmpleados.Add(new Empleado { Nombre = "Felix", Apellido = "Gallardo", EmpresaId = Pildoras.Id });

            dataContext.Empleados.InsertAllOnSubmit(listaEmpleados);

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.Empleados;

        }

        public void InsertarCargos()
        {
            dataContext.Cargos.InsertOnSubmit(new Cargo { NombreCargo = "Director" });

            dataContext.Cargos.InsertOnSubmit(new Cargo { NombreCargo = "Administrativo" });

            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.Cargos;
        }
    }
}
