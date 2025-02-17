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

namespace TodoApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private List<string> uppgifter = [];
    private List<int> index = [];

    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickLäggTill(object sender, RoutedEventArgs e)
    {
        string uppgift = txbUppgift.Text;

        if (uppgift != "")
        {
            uppgifter.Add(uppgift);

            tblLista.Text = string.Join("\n", uppgifter);

            txbUppgift.Text = "";     
        }
    }

    private void KlickRensa(object sender, RoutedEventArgs e)
    {
        tblLista.Text = "";
    }

    private void KlickTaBortUppgift(object sender, RoutedEventArgs e)
    {
        
    }
}