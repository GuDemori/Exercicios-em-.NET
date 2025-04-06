using System;
using System.Windows;

namespace SomaDoisNumeros
{
    public partial class VerificadorMaioridade : Window
    {
        public VerificadorMaioridade()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int idade = int.Parse(txtIdade.Text);

                if (idade >= 18)
                    MessageBox.Show("Maior de idade", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
                else
                    MessageBox.Show("Menor de idade", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite uma idade válida (apenas números).", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
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
