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

namespace RäknaUtArea;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickRäknaUt(object sender, RoutedEventArgs e)
    {
        // hämta heltal från bredd och höjd från textfärlten
            if (!int.TryParse(txbBredd.Text, out int bredd))
            {
                txbArea.Text = "Fel inmatning, Försök igen";
                txbBredd.Text = "";
                txbHöjd.Text = "";   
                return;          
            }
            if (!int.TryParse(txbHöjd.Text, out int höjd))
            {
                txbArea.Text = "Fel inmatning, Försök igen";
                txbBredd.Text = "";
                txbHöjd.Text = "";
                return;             
            }




        // beräkna arean
        int area = bredd * höjd;

        // visa resultatet i textfältet
        txbArea.Text = area.ToString();
    }

    private void KlickRensa(object sender, RoutedEventArgs e)
    {
        // Hämtar texten från textfälten
        txbBredd.Text = "";
        txbHöjd.Text = "";
        txbArea.Text = "";
    }
}