using System.Windows;

namespace SomaDoisNumeros
{
    public partial class JanelaMenu : Window
    {
        public JanelaMenu()
        {
            InitializeComponent();
        }

        private void AbrirSoma(object sender, RoutedEventArgs e)
        {
            MainWindow janela = new();
            janela.Show();
            this.Close();
        }

        private void AbrirConversor(object sender, RoutedEventArgs e)
        {
            ConversorTemperatura conversorTemperatura = new();
            conversorTemperatura.Show();
            this.Close();

        }

        private void AbrirDias(object sender, RoutedEventArgs e)
        {
            DiasParaAniversario diasParaAniversario = new();
            diasParaAniversario.Show();
            this.Close();
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            JanelaMenu menu = new JanelaMenu();
            menu.Show();
            this.Close();
        }
        private void AbrirMaioridade(object sender, RoutedEventArgs e)
        {
            VerificadorMaioridade janela = new VerificadorMaioridade();
            janela.Show();
            this.Close();
        }
        private void AbrirDescricaoEnum(object sender, RoutedEventArgs e)
        {
            ExibirDescricaoEnum janela = new ExibirDescricaoEnum();
            janela.Show();
            this.Close();
        }
        private void AbrirContadorCliques(object sender, RoutedEventArgs e)
        {
            ContadorCliques janela = new ContadorCliques();
            janela.Show();
            this.Close();
        }
        private void AbrirSimuladorParcelamento(object sender, RoutedEventArgs e)
        {
            SimuladorParcelamento janela = new SimuladorParcelamento();
            janela.Show();
            this.Close();
        }
        private void AbrirVerificarDiaSemana(object sender, RoutedEventArgs e)
        {
            VerificarDiaSemana janela = new VerificarDiaSemana();
            janela.Show();
            this.Close();
        }
        private void AbrirLigaDesliga(object sender, RoutedEventArgs e)
        {
            LigaDesliga janela = new LigaDesliga();
            janela.Show();
            this.Close();
        }
        private void AbrirSimuladorSorteio(object sender, RoutedEventArgs e)
        {
            SimuladorSorteio janela = new SimuladorSorteio();
            janela.Show();
            this.Close();
        }


    }
}
