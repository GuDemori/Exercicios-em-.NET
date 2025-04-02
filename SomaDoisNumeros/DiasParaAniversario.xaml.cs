using System;
using System.Windows;

namespace SomaDoisNumeros
{
    public partial class DiasParaAniversario : Window
    {
        public DiasParaAniversario()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if (dateNascimento.SelectedDate == null)
            {
                MessageBox.Show("Por favor, selecione sua data de nascimento.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            DateTime nascimento = dateNascimento.SelectedDate.Value;
            DateTime hoje = DateTime.Today;

            DateTime proximo = new DateTime(hoje.Year, nascimento.Month, nascimento.Day);

            if (proximo < hoje)
                proximo = proximo.AddYears(1);

            int diasRestantes = (proximo - hoje).Days;

            MessageBox.Show($"Faltam {diasRestantes} dias para o seu próximo aniversário!", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            JanelaMenu menu = new JanelaMenu();
            menu.Show();
            this.Close();
        }
    }
}
