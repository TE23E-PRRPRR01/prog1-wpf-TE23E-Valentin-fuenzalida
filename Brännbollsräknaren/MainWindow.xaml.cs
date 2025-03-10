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

    int poänginne = 0;
    int poängUte = 0;
    string frivarv = "Frivarv +5 poäng";
    string bränning = "Bränning +2 poäng";
    string lyra = "Lyra +3 poäng";
    string varv = "Varv +1 poäng";

    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickFrivarv(object sender, RoutedEventArgs e)
    {

        DateTime nu = DateTime.Now;
        poänginne += 5;
        tbxLagInne.Text = poänginne.ToString();
        tbxHistorik.Text += $"\n{nu.ToString("HH:mm:ss")} Lag inne: {poänginne}";

    }

    private void KlickBränning(object sender, RoutedEventArgs e)
    {
        poängUte += 2;
        tbxLagUte.Text = poängUte.ToString();
        tbxHistorik.Text += $"\nLag Ute: {poängUte}";

    }

    private void KlickLyra(object sender, RoutedEventArgs e)
    {
        poängUte += 3;
        tbxLagUte.Text = poängUte.ToString();
        tbxHistorik.Text += $"\nLag Ute: +{poängUte}";

    }

    private void KlickVarv(object sender, RoutedEventArgs e)
    {
        poänginne += 1;
        tbxLagInne.Text = poänginne.ToString();
        tbxHistorik.Text += $"\nLag inne: {poänginne}";
        
    }
}