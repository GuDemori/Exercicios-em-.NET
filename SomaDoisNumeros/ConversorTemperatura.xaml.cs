using System;
using System.Windows;

namespace SomaDoisNumeros
{
    public partial class ConversorTemperatura : Window
    {
        public ConversorTemperatura()
        {
            InitializeComponent();
        }

        private void BtnConverter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double celsius = double.Parse(txtCelsius.Text);
                double fahrenheit = (celsius * 9 / 5) + 32;

                MessageBox.Show($"{celsius}°C equivale a {fahrenheit:F2}°F", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, digite um número válido.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
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
