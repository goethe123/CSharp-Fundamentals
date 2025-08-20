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

namespace MiSegundaInterfaz;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        List <Capitales> ListaCapitales = new List <Capitales>();
        ListaCapitales.Add(new Capitales { NombreCapital = "madrids"});
        ListaCapitales.Add(new Capitales { NombreCapital = "Bogota" });
        ListaCapitales.Add(new Capitales { NombreCapital = "Lima" });
        ListaCapitales.Add(new Capitales { NombreCapital = "DF" });
        ListaCapitales.Add(new Capitales { NombreCapital = "Santiago" });

        Capitales.ItemsSource = ListaCapitales;

    }

    private void TodasCd_Checked(object sender, RoutedEventArgs e)
    {
        Bogota.IsChecked = true;
        Lima.IsChecked = true;
        DF.IsChecked = true;
        Santiago.IsChecked = true;
        Madrid.IsChecked = true;

    }

    private void TodasCd_Unchecked(object sender, RoutedEventArgs e)
    {
        Bogota.IsChecked = false;
        Lima.IsChecked = false;
        DF.IsChecked = false;
        Santiago.IsChecked = false;
        Madrid.IsChecked = false;

    }

    private void IndividualChecked(object sender, RoutedEventArgs e)
    {
        if (Bogota.IsChecked == true && Lima.IsChecked==true && DF.IsChecked ==true && Santiago.IsChecked == true && Madrid.IsChecked ==true )
        {
            TodasCd.IsChecked = true;
        }
        else
        {
            TodasCd.IsChecked = null;
        }
    }

    private void IndividualnoChecked(object sender, RoutedEventArgs e)
    {
        if (Bogota.IsChecked == false && Lima.IsChecked == false && DF.IsChecked == false && Santiago.IsChecked == false && Madrid.IsChecked == false)
        {
            TodasCd.IsChecked = false;
        }
        else
        {
            TodasCd.IsChecked = null;
        }
    }
}

public class Capitales
{
    public string NombreCapital { get; set; }
}
