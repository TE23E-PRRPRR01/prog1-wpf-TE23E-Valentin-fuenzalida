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
}