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

namespace Aritmetiken;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{


    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickBeräkna(object sender, RoutedEventArgs e)
    {
        string tal1text = tbxTal1.Text.Trim();
        string tal2text = tbxTal2.Text.Trim();

        string op = tbxOperator.Text.Trim();
        if (double.TryParse(tal1text, out double Tal1) & double.TryParse(tal2text, out double Tal2))
        {

            switch (op)
            {
                case "+":
                    lblResultat.Content = $"Resultat: {Tal1 + Tal2}";
                    break;
                case "-":
                    lblResultat.Content = $"Resultat: {Tal1 - Tal2}";
                    break;
                case "*":
                    lblResultat.Content = $"Resultat: {Tal1 * Tal2}";
                    break;
                case "/":
                    if (Tal1 != 0)
                    {
                        lblResultat.Content = $"Resultat: {Tal1 / Tal2}";
                    }
                    else
                    {
                        lblResultat.Content = "Fel: det går inte att devidera på 0";
                    }
                    break;
                default:
                    lblResultat.Content = "Fel: Ogiltigt tecken";
                    break;
            }
        }
        else
        {
            lblResultat.Content = "Fel: Ogiltigt tal";
        }

    }

    private void KlickRensa(object sender, RoutedEventArgs e)
    {
        tbxTal1.Text = "";
        tbxTal2.Text = "";
        tbxOperator.Text = "";
        lblResultat.Content = "";

    }
}