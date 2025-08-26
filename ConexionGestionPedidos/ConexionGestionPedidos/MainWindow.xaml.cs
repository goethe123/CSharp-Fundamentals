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
using System.Security.Cryptography;

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
            MuestraTodosPedidos();
        }
        

        private void MuestraClientes()
        {
            try
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
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void MuestraPedidos ()
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void MuestraTodosPedidos()
        {
            try
            {
                string consulta = "SELECT *, CONCAT(CCLIENTE, ' ', fechaPedido, ' ', formaPago) AS INFOCOMPLETA FROM PEDIDO";
                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);
                using (miAdaptadorSql)
                {
                    DataTable pedidosTabla = new DataTable();

                    miAdaptadorSql.Fill(pedidosTabla);

                    TodosPedidos.DisplayMemberPath = "INFOCOMPLETA";
                    TodosPedidos.SelectedValuePath = "Id";
                    TodosPedidos.ItemsSource = pedidosTabla.DefaultView;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
       /* private void ListaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show("Has hecho click en un cliente");
            MuestraPedidos();
        }*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //  MessageBox.Show(TodosPedidos.SelectedValue.ToString());
            String consulta = "DELETE FROM PEDIDO WHERE ID = @PEDIDOID";
            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
            miConexionSql.Open();
            miSqlCommand.Parameters.AddWithValue("@PEDIDOID", TodosPedidos.SelectedValue);
            miSqlCommand.ExecuteNonQuery();
            miConexionSql.Close();
            MuestraPedidos();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String consulta = "INSERT INTO CLIENTE(nombre) VALUES (@nombre)";

            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            miSqlCommand.Parameters.AddWithValue("@nombre", insertaCliente.Text);

            miSqlCommand.ExecuteNonQuery();

            miConexionSql.Close();

            MuestraClientes();

            insertaCliente.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            String consulta = "DELETE FROM CLIENTE WHERE ID = @CLIENTEID";

            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            miSqlCommand.Parameters.AddWithValue("@CLIENTEID", ListaClientes.SelectedValue);

            miSqlCommand.ExecuteNonQuery();

            miConexionSql.Close();

            MuestraClientes();
        }

        private void listaClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MuestraPedidos();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Actualizar ventanaActualizar = new Actualizar((int)ListaClientes.SelectedValue);
            ventanaActualizar.Show();
           

            try
            {
                string Consulta = "SELECT nombre FROM CLIENTE where Id = @ClId";
                SqlCommand miSqlCommand = new SqlCommand(Consulta, miConexionSql);

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(miSqlCommand);

                using (miAdaptadorSql)
                {
                    miSqlCommand.Parameters.AddWithValue("@ClId", ListaClientes.SelectedValue);
                    DataTable clientesTabla = new DataTable();
                    miAdaptadorSql.Fill(clientesTabla);
                    ventanaActualizar.cuadroActualiza.Text= clientesTabla.Rows[0]["nombre"].ToString();
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString());
            }
         
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            MuestraClientes();
        }
    }
    }

