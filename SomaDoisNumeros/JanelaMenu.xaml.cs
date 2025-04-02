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
    }
}
