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

namespace SlumpTalApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void SlumpaTal(object sender, RoutedEventArgs e)
    {
        int slumptal;
        if (!int.TryParse(txbMaxvärde.Text, out int maxvärde))
        {

            // Generera ett slumptal mellan 1 och 100
            slumptal = Random.Shared.Next(1, 101);

            // visa slumptalet i textboxen resultat
            txbResultat.Text = slumptal.ToString();

            txbMaxvärde.Text = "";
            txbEj.Text = "Max är inte ett heltal";
            return;


        }

        txbEj.Text = "";

        // Generera ett slumptal mellan 1 och 100
        slumptal = Random.Shared.Next(1, (maxvärde + 1));

        // visa slumptalet i textboxen resultat
        txbResultat.Text = slumptal.ToString();
    }

    private void SlumpaTioTal(object sender, RoutedEventArgs e)
    {
        List<int> SlumpaTioTalList = [];
        for (int i = 0; i < 10; i++)
        {
            SlumpaTioTalList.Add(Random.Shared.Next(1, 101));
        }

        txbFlerResultat.Text = string.Join(" ", SlumpaTioTalList);
    }
}