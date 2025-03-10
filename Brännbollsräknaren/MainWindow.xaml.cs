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

namespace Brännbollsräknaren;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // Skapa variablerna för lagen.
    int poängInne = 0;
    int poängUte = 0;
    public MainWindow()
    {
        InitializeComponent();

    }

    private void KlickFrivarv(object sender, RoutedEventArgs e)
    {
        // Lägg till 5 poäng.
        poängInne += 5;

        // Skriv ut poängen.
        txbInne.Text = $"{poängInne}";
        
        // Vad är klockan just nu?
        DateTime nu = DateTime.Now;

        // Skriv ut Historiken.
        txbHistorik.Text += $"{nu.ToString("HH.mm.ss ")}Lagg inne +5, totalt: {poängInne}\n";
    }
    
    private void KlickBränning(object sender, RoutedEventArgs e)
    {
        poängUte += 2;
        txbUte.Text = $"{poängUte}";
    }

    private void KlickLyra(object sender, RoutedEventArgs e)
    {
        poängUte += 3;
        txbUte.Text = $"{poängUte}";
    }

    private void KlickVarv(object sender, RoutedEventArgs e)
    {
        poängInne += 1;
        txbInne.Text = $"{poängInne}";
    }
}