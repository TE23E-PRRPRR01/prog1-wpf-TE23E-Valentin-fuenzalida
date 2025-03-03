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
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

namespace Epostaddress;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }


    //hantera klick på knappen skicka
    private void KlickSkicka(object sender, RoutedEventArgs e)
    {
        string epost = tbxEpost.Text;
        string text = tbxText.Text;

        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.EnableSsl = true;
        smtp.Credentials = new NetworkCredential("valentin.fuenzalidaribbing@elev.ga.ntig.se", "Valentin12345");

        // kontrollera att användaren har skrivit in en epostadress 
        string regexEpost = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        if (!Regex.IsMatch(epost, regexEpost))
        {
            // VIsa felmeddelande
            lblStatus.Content = "Du måste ange en epostadress";
        }
        else
        {
            smtp.Send("valentin.fuenzalidaribbing@elev.ga.ntig.se", epost, "Meddelande från WPF", text);

            lblStatus.Content = "Meddelandet skickades!";
        }
    }

    private void ChangedEpost(object sender, RoutedEventArgs e)
    {
        // läs av epost meddelande
        string epost = tbxEpost.Text;

        // Kontrollera att användaren har skrivit in en epostadress
        string regexEpost = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        if (!Regex.IsMatch(epost, regexEpost))
        {
            // Visa felmeddelande
            lblStatus.Text = "Du måste ange en giltig epostadress!";
        }
        else
        {

        }
    }
}