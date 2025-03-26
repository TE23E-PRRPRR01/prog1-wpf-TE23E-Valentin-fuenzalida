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

namespace Swishapp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private int Kontobalans;

    public MainWindow()
    {
        InitializeComponent();

        Kontobalans = Random.Shared.Next(100, 301);
        tbxKontobalans.Text = $"{Kontobalans}";
    }

    private void btnSwisha(object sender, RoutedEventArgs e)
    {


        string belopp = tbxÖnskatBelopp.Text;

        if (int.TryParse(belopp, out int Swisha))
        {
            if (Swisha <= Kontobalans)
            {
                Kontobalans -= Swisha;
                tbxKontobalans.Text = $"{Kontobalans} kr";
                lblResultat.Content = $"Swishat: {Swisha} kr";
            }
        }

        else
        {
            lblResultat.Content = "Ogiltigt belopp.";
        }
    }

}