using System;
using System.Collections.Generic;
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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ConexionGestionPedidos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SqlConnection miConexionSql;
        public MainWindow()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
            MuestraClientes();
        }
        

        private void MuestraClientes()
        {
            string Consulta = "SELECT * FROM CLIENTE";

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(Consulta, miConexionSql);

            using (miAdaptadorSql)
            {
                DataTable ClientesTabla = new DataTable();
                miAdaptadorSql.Fill(ClientesTabla);
                ListaClientes.DisplayMemberPath = "nombre";
                ListaClientes.SelectedValuePath = "Id";
                ListaClientes.ItemsSource = ClientesTabla.DefaultView;
            }
        }

        private void MuestraPedidos ()
        {

            string Consulta = "SELECT * FROM PEDIDO P INNER JOIN CLIENTE C ON C.ID=P.cCliente" + " WHERE C.ID=@ClienteId";

            SqlCommand sqlComando = new SqlCommand(Consulta, miConexionSql);


            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);

            using (miAdaptadorSql)
            {
                sqlComando.Parameters.AddWithValue("@ClienteId", ListaClientes.SelectedValue);
                DataTable PedidosTabla = new DataTable();
                miAdaptadorSql.Fill(PedidosTabla);
                PedidosCliente.DisplayMemberPath = "fechaPedido";
                PedidosCliente.SelectedValuePath = "Id";
                PedidosCliente.ItemsSource = PedidosTabla.DefaultView;
            }

        }
        private void ListaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show("Has hecho click en un cliente");
            MuestraPedidos();
        }
    }
}

