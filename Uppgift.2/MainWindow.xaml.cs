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

namespace Uppgift._2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnRäkna(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(tbxtal1.Text, out double tal1) && double.TryParse(tbxtal2.Text, out double tal2))
        {
            if (sender == plus) tbxResultat.Text = $"{tal1} + {tal2} = {tal1 + tal2}";
            if (sender == minus) tbxResultat.Text = $"{tal1} - {tal2} = {tal1 - tal2}";
            if (sender == multi) tbxResultat.Text = $"{tal1} * {tal2} = {tal1 * tal2}";
            if (sender == divi) tbxResultat.Text = $"{tal1} / {tal2} = {tal1 / tal2}";
        }
        else
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Felaktig inmatning.\nFormatera talen som tex 12 eller 12,5");
        }
    }
}