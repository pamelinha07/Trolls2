using Microsoft.Maui.Controls;

namespace Trolls2
{
    public partial class Tamanhos : ContentPage
    {
        public Tamanhos()
        {
            InitializeComponent();
        }

        private async void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Lógica para o botão Voltar
            await Navigation.PopAsync();
        }

        private async void OnProximoButtonClicked(object sender, EventArgs e)
        {
            // Lógica para o botão Próximo
            await Navigation.PushAsync(new ProximaPagina());
        }
    }
}
