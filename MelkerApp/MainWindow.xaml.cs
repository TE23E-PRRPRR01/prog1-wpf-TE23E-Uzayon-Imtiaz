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

namespace MelkerApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickJämför(object sender, RoutedEventArgs e)
    {
        // Läs av textrutorna.
        string tal1 = txbTal1.Text;
        string tal2 = txbTal2.Text;

        // Omvandla till heltal.
        int.TryParse(tal1, out int tal1Tal);
        int.TryParse(tal2, out int tal2Tal);

        // Jämförelsen.
        if (tal1Tal == tal2Tal)
        {
            txbResultat.Text = "Talen är lika!";
        }
        else if (tal1Tal > tal2Tal)
        {
            txbResultat.Text = $"{tal1} är störst!";
        }
        else
        {
            txbResultat.Text = $"{tal2} är störst!";
        }
    }
}