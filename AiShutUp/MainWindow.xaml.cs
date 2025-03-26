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
using System.Net.Http;
using System.Net.Http.Json;

namespace AiShutUp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    //redskap för att kommunicera över http 
    HttpClient klient = new HttpClient();
    string url = "http://10.151.168.5:11434/api/generate";


    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSkicka(object sender, RoutedEventArgs e)
    {
        // läsa av prompt texten i rutan
        string prompt = txbPrompt.Text;

        // skapa en json-objekt
        object data = new
        {
            model = "phi4:latest",
            prompt = prompt,
            max_tokens = 50
        };

        // skicka till ollama ai-servern
        SkickaTillollama(data);
    }

    public void SkickaTillollama(object data)
    {
        try
        {
            // Skicka data till servern
            HttpResponseMessage svar = klient.PostAsJsonAsync(url, data).Result;

            // kontrollera att "requesööööööööööööööööööööööööten" lyckades
            svar.EnsureSuccessStatusCode();

            // läs innehållet i svaret
            string råtext = svar.Content.ReadAsStringAsync().Result;

            // dela upp råtexten i rader
            string[] rader = råtext.Split("\n");

            // gå igenom alla rader
            foreach (string rad in rader)
            {
                // finns "response"
                if (rad.Contains("response"))
                {
                    txbSvar.Text += PlockaUtToken(rad);
                }
            }

        }
        catch (HttpRequestException e)
        {
            txbSvar.Text = $"Fel: {e.Message}";
        }
    }

    public string PlockaUtToken(string rad)
    {
        int start = rad.IndexOf("response") + 11;
        int slut = rad.IndexOf("\"", start);

        // plicka ut token
        return rad.Substring(start, slut -start);
        
    }
}