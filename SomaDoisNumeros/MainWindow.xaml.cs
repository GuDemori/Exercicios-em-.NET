using System;
using System.Windows;

namespace SomaDoisNumeros
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSomar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int numero1 = int.Parse(txtNumero1.Text);
                int numero2 = int.Parse(txtNumero2.Text);
                int soma = numero1 + numero2;

                MessageBox.Show($"A soma é: {soma}", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, digite apenas números inteiros válidos.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            JanelaMenu menu = new JanelaMenu();
            menu.Show();
            this.Close();
        }

    }
}
