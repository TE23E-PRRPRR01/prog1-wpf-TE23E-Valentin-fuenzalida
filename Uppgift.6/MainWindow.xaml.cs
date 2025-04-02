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

namespace Uppgift._6;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    double antal;
    double summa;
    double medelvärdet;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnAddera(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(tbxTal.Text, out double tal))
        {

            tbxSumma.Text = $"{tal} + {summa} = {tal + summa}";
            summa += tal;

            antal ++;

            tbxMedelvärdet.Text = $"{summa} / {antal} = {summa/antal}";

        }
    }
}