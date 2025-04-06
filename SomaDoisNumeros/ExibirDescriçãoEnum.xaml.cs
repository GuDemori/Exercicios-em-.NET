using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows;

namespace SomaDoisNumeros
{
    public enum TipoUsuario
    {
        [Description("Usuário com permissões totais")]
        Administrador,

        [Description("Usuário comum com acesso limitado")]
        UsuarioComum,

        [Description("Visitante com acesso restrito")]
        Visitante
    }

    public partial class ExibirDescricaoEnum : Window
    {
        public ExibirDescricaoEnum()
        {
            InitializeComponent();
            comboTipoUsuario.ItemsSource = Enum.GetValues(typeof(TipoUsuario));
        }

        private void BtnExibir_Click(object sender, RoutedEventArgs e)
        {
            if (comboTipoUsuario.SelectedItem is TipoUsuario tipo)
            {
                string descricao = ObterDescricaoEnum(tipo);
                MessageBox.Show(descricao, "Descrição", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Selecione um tipo de usuário.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private string ObterDescricaoEnum(Enum valor)
        {
            FieldInfo campo = valor.GetType().GetField(valor.ToString());
            DescriptionAttribute atributo = (DescriptionAttribute)Attribute.GetCustomAttribute(campo, typeof(DescriptionAttribute));
            return atributo?.Description ?? valor.ToString();
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            JanelaMenu menu = new JanelaMenu();
            menu.Show();
            this.Close();
        }
    }
}
