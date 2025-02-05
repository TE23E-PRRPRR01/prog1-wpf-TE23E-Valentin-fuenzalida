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

namespace Evenapp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickOk(object sender, RoutedEventArgs e)
    {   
        // läsa av texten i textrutan
        string text = tbxText.Text;

        // visa texten i textrutan tbxResultat
        tbxResultat.Text = text;
    }

    // Ny metod för att hantera klicksignalen från knappen Avbryt
    private void KlickAvbryt(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Du klickade på Avbryt");
    }

    private void KlickRensa(object sender, RoutedEventArgs e)
    {
        
    }
}
