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

namespace ValutaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void KlickUSD(object sender, RoutedEventArgs e)
    {
        // Läs av beloppet.
        string belopp = txbBelopp.Text;

        // Omvandla till tal. 
        int.TryParse(belopp, out int beloppTal);

        // Räkna hur mycket i USD (9,64).
        double beloppUSD = beloppTal / 9.64;
        
        // Skriv ut resultatet.
        // T.ex "100:- är $10.38".
        txbResultat.Text = $"{beloppTal} SEK motsvarar ${beloppUSD}.";
        
    }
     private void KlickEUR(object sender, RoutedEventArgs e)
    {
        // Läs av beloppet.
        string belopp = txbBelopp.Text;

        // Omvandla till tal. 
        int.TryParse(belopp, out int beloppTal);

        // Räkna hur mycket i EUR (10,98).
        double beloppEUR = beloppTal / 10.98;
        
        // Skriv ut resultatet.
        // T.ex "100:- är $10.38".
        txbResultat.Text = $"{beloppTal} SEK motsvarar ${beloppEUR}.";
    }

     private void KlickGBP(object sender, RoutedEventArgs e)
    {
        // Läs av beloppet.
        string belopp = txbBelopp.Text;

        // Omvandla till tal. 
        int.TryParse(belopp, out int beloppTal);

        // Räkna hur mycket i GBP (12,9).
        double beloppGBP = beloppTal / 12.9;
        
        // Skriv ut resultatet.
        // T.ex "100:- är $10.38".
        txbResultat.Text = $"{beloppTal} SEK motsvarar ${beloppGBP}.";
    }
}