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

namespace Provuppgifter;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void BeräknaPorto(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Du klickade på Beräkna porto");
        
        // string text = BeräknaPorto.tbxVikt;
        // MessageBox.Show($"Du track in: {BeräknaPorto}");
    }
}