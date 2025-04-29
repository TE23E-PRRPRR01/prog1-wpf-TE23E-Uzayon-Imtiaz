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

namespace ASDASDASD;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickRäkna(object sender, RoutedEventArgs e)
    {
        if (int.TryParse(txbcalc.Text, out int vikt))
        {
            string output = BeraknaPorto(vikt);
            string output = 
            Resultat.Content = output;
        }
        else
        {
            Resultat.Content = "Ogitlig vikt";
        }
    }

    private string BeraknaPorto(object sender, RoutedEventArgs e)
    {
        if (vikt <= 50)
        {
            Resultat.Content = "oiuef";
        }
    }
}