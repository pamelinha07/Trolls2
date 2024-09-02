using System;
using Microsoft.Maui.Controls;

namespace Trolls2
{
    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void OnProximoClicked(object sender, EventArgs e)
        { 
            bool isValid = ValidateEntries();
            ErrorLabel.IsVisible = !isValid;

            if (isValid)
            {
                // Lógica para próximo
            }
        }

        private bool ValidateEntries()
        {
            bool isNomeValid = !string.IsNullOrWhiteSpace(NomeEntry.Text);
            bool isTelefoneValid = !string.IsNullOrWhiteSpace(TelefoneEntry.Text);
            bool isCnpjValid = !string.IsNullOrWhiteSpace(CnpjEntry.Text);
            bool isEnderecoValid = !string.IsNullOrWhiteSpace(EnderecoEntry.Text);

            return isNomeValid && isTelefoneValid && isCnpjValid && isEnderecoValid;
        }
    }
}
