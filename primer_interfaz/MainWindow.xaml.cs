using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace primer_interfaz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> listapob = new List<Poblaciones>();
            {
                listapob.Add(new Poblaciones() { poblacion1 = "Madrid", poblacion2 = "Barcelona", temperatura1 = 15, temperatura2 = 17, DiferenciaTemp= 2 });

                listapob.Add(new Poblaciones() { poblacion1 = "Valencia", poblacion2 = "Valencia", temperatura1 = 19, temperatura2 = 20, DiferenciaTemp=1 });
                listapob.Add(new Poblaciones() { poblacion1 = "Migala", poblacion2 = "Bilbao", temperatura1 = 20, temperatura2 = 7, DiferenciaTemp = 13 });
                listapob.Add(new Poblaciones() { poblacion1 = "Sevilla", poblacion2 = "Coruña", temperatura1 = 13, temperatura2 = 17, DiferenciaTemp = 4 });
                ListaPoblaciones.ItemsSource = listapob;
            }
            




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ListaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((ListaPoblaciones.SelectedItem as Poblaciones).poblacion1 + "  " +
                    (ListaPoblaciones.SelectedItem as Poblaciones).temperatura1 + " grados centigrados " +
                    (ListaPoblaciones.SelectedItem as Poblaciones).poblacion2 + "  " +
                    (ListaPoblaciones.SelectedItem as Poblaciones).temperatura2 + " grados centigrados ");
            }
            else
            {
                MessageBox.Show(("No has seleccionado nada"));
            }

        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ListaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((ListaPoblaciones.SelectedItem as Poblaciones).poblacion1 + "  " +
                    (ListaPoblaciones.SelectedItem as Poblaciones).temperatura1 + " grados centigrados " +
                    (ListaPoblaciones.SelectedItem as Poblaciones).poblacion2 + "  " +
                    (ListaPoblaciones.SelectedItem as Poblaciones).temperatura2 + " grados centigrados ");
            }
            else
            {
                MessageBox.Show(("No has seleccionado nada"));
            }
        }
    }

    public class Poblaciones
    {   
        public string poblacion1 { get; set; }

        public int temperatura1 { get; set; }
        public string poblacion2 { get; set; }

        public int temperatura2 { get; set; }

        public int DiferenciaTemp { get; set; }
    }
}