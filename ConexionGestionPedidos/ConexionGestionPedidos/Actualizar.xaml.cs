using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Shapes;
using System.Configuration;
using System.Data;

namespace ConexionGestionPedidos
{
    /// <summary>
    /// Interaction logic for Actualizar.xaml
    /// </summary>
    public partial class Actualizar : Window
    {

        SqlConnection miConexionSql;

        private int z;
        public Actualizar(int elId)
        {
            InitializeComponent();

            z = elId;


            string miConexion = ConfigurationManager.ConnectionStrings["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            String consulta = "UPDATE CLIENTE SET nombre=@nombre WHERE Id=" + z;

            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);

            miConexionSql.Open();

            miSqlCommand.Parameters.AddWithValue("@nombre", cuadroActualiza.Text);

            miSqlCommand.ExecuteNonQuery();

            miConexionSql.Close();

            this.Close();

           
        }
    }
}
