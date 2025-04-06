using System.Windows;

namespace SomaDoisNumeros
{
    public partial class ContadorCliques : Window
    {
        private int contador = 0;

        public ContadorCliques()
        {
            InitializeComponent();
        }

        private void BtnContar_Click(object sender, RoutedEventArgs e)
        {
            contador++;
            MessageBox.Show($"Número de cliques: {contador}", "Contador", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            JanelaMenu menu = new JanelaMenu();
            menu.Show();
            this.Close();
        }
    }
}
