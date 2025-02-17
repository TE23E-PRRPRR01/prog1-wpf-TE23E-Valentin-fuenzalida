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

namespace GissaTal;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private int hemligtal;
    private int antalGissningar = 0;

    public MainWindow()
    {
        InitializeComponent();

        hemligtal = Random.Shared.Next(1, 101);
    }

    private void KlickGissa(object sender, RoutedEventArgs e)
    {
        if (!int.TryParse(txbGissning.Text, out int gissning))
        {
            txbResultat.Text = "Du måste gissa ett heltal";
        }
        if (gissning != hemligtal && int.TryParse(txbGissning.Text, out gissning))
        {
            txbResultat.Text = "Du gisade fel, försök igen";
            antalGissningar++;
            txbAntalGissningar.Text = $"Du har gissat {antalGissningar} gånger";
        }
        if (gissning == hemligtal)
        {
            txbResultat.Text = "Du gissade rätt";
        }
    }

    private void KlickStartaOm(object sender, RoutedEventArgs e)
    {
        txbResultat.Text = "";

        txbGissning.Text = "";

        hemligtal = Random.Shared.Next(1, 101);

    }

}