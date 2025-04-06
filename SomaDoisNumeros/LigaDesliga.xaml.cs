using System.Windows;

namespace SomaDoisNumeros
{
    public partial class LigaDesliga : Window
    {
        private bool ligado = false;

        public LigaDesliga()
        {
            InitializeComponent();
        }

        private void BtnAlternar_Click(object sender, RoutedEventArgs e)
        {
            ligado = !ligado;

            string estado = ligado ? "Ligado" : "Desligado";
            MessageBox.Show($"Estado atual: {estado}", "Interruptor", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            JanelaMenu menu = new JanelaMenu();
            menu.Show();
            this.Close();
        }
    }
}
