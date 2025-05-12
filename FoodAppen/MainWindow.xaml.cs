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

namespace FoodAppen;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    // Lista för att lagra sparande recept.
    List<string> receptLista =[];
    private void KlickVisa(object sender, RoutedEventArgs e)
    {
        // Omvandla!
        string namn = tbxName.Text;
        string ingrediens = txbIngrediens.Text;
        string tidText = txbTid.Text;
        int.TryParse(tidText, out int tid);

        // Skriv ut resultat.
        txbResultat.Text = $"Namn: {namn}\nIngrediens: {ingrediens}\nTid: {tid}";
        
        // Om huvudingrediensen inte är kött eller fisk ska det stå "OBS! Ovanlig ingrediens.".
        if (ingrediens == "Kött" || ingrediens == "Fisk" || ingrediens == "kött" || ingrediens == "fisk")
        {
            txbResultat.Text = $"Namn: {namn}\nIngrediens: {ingrediens}\nTid: {tid}";
        }
        else
        {
            txbResultat.Text = $"Namn: {namn}\nIngrediens: {ingrediens}\nTid: {tid}\nOBS! Ovanlig ingrediens.";
        }

    }
    private void KlickRensa(object sender, RoutedEventArgs e)
    {
        txbResultat.Text = "";
    }
    private void KlickSpara(object sender, RoutedEventArgs e)
    {
        receptLista.Add(txbResultat.Text);
        txbAntal.Text = $"Antal recept: {receptLista.Count}";
    
    }
    private void KlickVisaLista(object sender, RoutedEventArgs e)
    {
        foreach (string recept in receptLista)
        {
            txbLista.Text += recept + "\n\n";
        }
    }
}