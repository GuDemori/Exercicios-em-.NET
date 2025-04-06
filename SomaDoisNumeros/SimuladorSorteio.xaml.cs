using System;
using System.Windows;

namespace SomaDoisNumeros
{
    public partial class SimuladorSorteio : Window
    {
        private Random random = new Random();

        public SimuladorSorteio()
        {
            InitializeComponent();
        }

        private void BtnSortear_Click(object sender, RoutedEventArgs e)
        {
            int numeroSorteado = random.Next(1, 7);

            string mensagem = numeroSorteado == 6
                ? "Você ganhou!"
                : "Tente novamente!";

            MessageBox.Show($"Número sorteado: {numeroSorteado}\n{mensagem}",
                            "Resultado do Sorteio", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            JanelaMenu menu = new JanelaMenu();
            menu.Show();
            this.Close();
        }
    }
}
