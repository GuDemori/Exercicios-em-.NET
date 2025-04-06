using System;
using System.Windows;

namespace SomaDoisNumeros
{
    public partial class SimuladorParcelamento : Window
    {
        public SimuladorParcelamento()
        {
            InitializeComponent();

            for (int i = 1; i <= 12; i++)
            {
                comboParcelas.Items.Add(i);
            }

            comboParcelas.SelectedIndex = 0;
        }
        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double valorTotal = double.Parse(txtValorTotal.Text);

                if (comboParcelas.SelectedItem is int qtdParcelas && qtdParcelas > 0)
                {
                    double valorParcela = valorTotal / qtdParcelas;
                    MessageBox.Show($"Valor de cada parcela ({qtdParcelas}x): R$ {valorParcela:F2}", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Selecione uma quantidade de parcelas válida.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite um valor numérico válido no campo de valor total.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
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
