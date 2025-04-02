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

namespace Ceasar_krypto;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }


    private void btnKör(object sender, RoutedEventArgs e)
    {

        string text = tbxText.Text;
        string nyckelString = tbxNyckel.Text;

        int nyckel = 0;
        if (!int.TryParse(nyckelString, out nyckel))
        {
            tbxResultat.Text = "Du måste mata in ett tal (1-9). Försök igen: ";
            nyckelString = Console.ReadLine();
        }
        else
        {
            string kryptadText = "";
            for (int i = 0; i < text.Length; i++)
            {
                char bokstav = text[i];
                int ascii = (int)bokstav;

                int kryptadAscii = ascii + nyckel;

                if (kryptadAscii >= 90)
                {
                    kryptadAscii -= 26;
                }

                char kryptadBokstav = (char)(kryptadAscii);

                kryptadText += kryptadBokstav.ToString();
            }

            tbxResultat.Text = $"{kryptadText}";
        }





    }
}