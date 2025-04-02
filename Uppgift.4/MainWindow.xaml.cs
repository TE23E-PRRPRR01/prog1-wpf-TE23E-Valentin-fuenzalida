using System.IO;
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
using Microsoft.Win32;

namespace Uppgift._4;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnÖppna(object sender, RoutedEventArgs e)
    {
        if (!File.Exists(tbxFilnamn.Text))
        {
            MessageBox.Show("fel: filen finns inte");
        }
        else
        {
            resultatRuta.Text = File.ReadAllText(tbxFilnamn.Text);
        }
    }

    private void btnvälj(object sender, RoutedEventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Title = "Välj en fil";
        openFileDialog.Filter = "Textfiler (*.txt)|*.txt|Alla filer (*.*)|*.*";  // Begränsar filvalet (valfritt)

        if (openFileDialog.ShowDialog() == true)  // Om användaren valt en fil
        {
            tbxFilnamn.Text = openFileDialog.FileName;  // Visar filnamnet i en TextBox
        }
    }
}