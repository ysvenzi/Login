using System.Windows;

namespace Login;

public partial class MainWindow : Window
{
    // Inicio Main
    private const string USUARIO_PADRAO = "admin";
    private const string SENHA_PADRAO = "admin";

    public MainWindow()
    {
        InitializeComponent();
    }

    private void BotaoLogin(object sender, RoutedEventArgs e)
    {
        var usuarioDigitado = tbUsuario.Text;
        var senhaDigitada = tbSenha.Text;

        if (string.IsNullOrWhiteSpace(usuarioDigitado) || string.IsNullOrWhiteSpace(senhaDigitada))
        {
            MessageBox.Show("Usuario e senha precisam ser informados", "Informação pendente");
            return;
        }

        if (usuarioDigitado != USUARIO_PADRAO || senhaDigitada != SENHA_PADRAO)
        {
            // True
            MessageBox.Show("Usuario e/ou senha estão errados", "Erro");
            return;
        }

        MessageBox.Show("Boas vindas, Admin");
        var novaJanela = new Painel();
        novaJanela.Show();
    } // Fim BotaoLogin

    private void BotaoCadastro(object sender, RoutedEventArgs e)
    {
        var janelaCadastro = new Cadastro(); // Aqui ele constroi a janela na memoria RAM
        janelaCadastro.Show(); // Exibe a janela no monitor
    }
} // Fim Main