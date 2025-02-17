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

namespace OmRöstning;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private int antalRöd = 0;
    private int antalBlå = 0;
    private int antalGrön = 0;
    private int antalLila = 0;
    private int antalGul = 0;
    private int antalBrun = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickRösta(object sender, RoutedEventArgs e)
    {
        if (sender == röd)
        {
            antalRöd++;
        }
        else if (sender == blå)
        {
            antalBlå++;
        }
        else if (sender == grön)
        {
            antalGrön++;
        }
        if (sender == lila)
        {
            antalLila++;
        }
        else if (sender == gul)
        {
            antalGul++;
        }
        else if (sender == brun)
        {
            antalBrun++;
        }

        txbResultat.Text  = $"Röd: {antalRöd}, Blå: {antalBlå}, Grön: {antalGrön}, Lila: {antalLila}, Gul: {antalGul}, Brun: {antalBrun}";
    }

    private void KlickRensa(object sender, RoutedEventArgs e)
    {
        antalRöd = 0;
        antalBlå = 0;
        antalGrön = 0;
        antalLila = 0;
        antalGul = 0;
        antalBrun = 0;

                txbResultat.Text  = $"Röd: {antalRöd}, Blå: {antalBlå}, Grön: {antalGrön}, Lila: {antalLila}, Gul: {antalGul}, Brun: {antalBrun}";
    }

}