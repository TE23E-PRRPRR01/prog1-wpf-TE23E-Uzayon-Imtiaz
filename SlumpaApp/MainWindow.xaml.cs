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

namespace SlumpaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSlumpa(object sender, RoutedEventArgs e)
    {
        // Läsa av maxvärde.
        // Max kan man bara skapa.
        // int max = int.Parse(txbMaxgräns.Text) +  1;

        // Parse gör så programen kraschar när man skiver något utan tal.
        // Läsa av utan risk för krasch!
        if (!int.TryParse(txbMaxgräns.Text, out var max))
        {
            max = 100;
        }
        // int max = int.TryParse(txbMaxgräns.Text) +  1;

        // Slumpa ett tal 1-100.
        // och lägg in max.
        int slumptal = Random.Shared.Next(1, max + 1);

        // Skvriv ut slumptalet i textboxen.
        // Kommentaren nedan fungerar också!
        // txbResultat.Text = slumptal.ToString();
        txbResultat.Text = $"{slumptal}";
    }
}