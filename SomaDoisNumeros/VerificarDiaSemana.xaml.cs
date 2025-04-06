using System;
using System.Windows;

namespace SomaDoisNumeros
{
    public enum DiaSemana
    {
        Domingo,
        SegundaFeira,
        TercaFeira,
        QuartaFeira,
        QuintaFeira,
        SextaFeira,
        Sabado
    }

    public partial class VerificarDiaSemana : Window
    {
        public VerificarDiaSemana()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, RoutedEventArgs e)
        {
            if (dateSelecionada.SelectedDate == null)
            {
                MessageBox.Show("Por favor, selecione uma data.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            DateTime data = dateSelecionada.SelectedDate.Value;
            DiaSemana dia = (DiaSemana)data.DayOfWeek;

            MessageBox.Show($"O dia da semana é: {dia}", "Resultado", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            JanelaMenu menu = new JanelaMenu();
            menu.Show();
            this.Close();
        }
    }
}
