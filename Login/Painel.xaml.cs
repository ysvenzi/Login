using System.Windows;
using System.Windows.Media.Imaging;

namespace Login;

public partial class Painel : Window
{
    private int tempoMaximo = 30;
    
    public Painel()
    {
        InitializeComponent();
    }

    private void BotaoBuscarImagem(object sender, RoutedEventArgs e)
    {
        var nomeEstudante = tbEstudanteNome.Text;

        //Estrutura Switch-case
        switch (nomeEstudante.ToLower())
        {
            case "rebeca spinola":
                ImagemAluna.Source =
                    CriarImagem("https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/001.png");
                break;

            case "sarah":
                ImagemAluna.Source =
                    CriarImagem("https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/004.png");
                break;

            case "yatra":
                ImagemAluna.Source =
                    CriarImagem("https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/007.png");
                break;

            case "isabela":
                ImagemAluna.Source =
                    CriarImagem("https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/495.png")
                    ;
                break;

            case "maria fernanda":
                ImagemAluna.Source =
                    CriarImagem("https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/498.png");
                break;

            case "laura":
                ImagemAluna.Source =
                    CriarImagem("https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/501.png");
                break;

            case "joyce":
                ImagemAluna.Source =
                    CriarImagem("https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/722.png");
                break;

            case "rebecca dias":
                ImagemAluna.Source =
                    CriarImagem("https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/725.png");
                break;

            case "adrielly":
                ImagemAluna.Source =
                    CriarImagem("https://www.pokemon.com/static-assets/content-assets/cms2/img/pokedex/full/728.png");
                break;

            default:
                ImagemAluna.Source = CriarImagem("pack://application:,,,/Images/chikorita.png");
                break;
        }
    }

    private static BitmapImage CriarImagem(string url)
    {
        var imagemBitmap = new BitmapImage();
        imagemBitmap.BeginInit();
        imagemBitmap.UriSource = new Uri(url);
        imagemBitmap.EndInit();
        return imagemBitmap;
    }

    private async Task GerenciarContagemRegressiva()
    {
        int contador = 0;
        while(contador < tempoMaximo)
        {
            await Task.Delay(1000);
            contador++;
            displayTemporizador.Text = $"Contagem Regressiva: {tempoMaximo - contador}s"; 
        }    
        
        this.Close();
    }

    private async void QuandoJanelaAbrir(object sender, RoutedEventArgs e)
    {
        await GerenciarContagemRegressiva();
    }
}