using Microsoft.Maui.Controls;

namespace Trolls2
{
    public partial class Quantidade : ContentPage
    {
        public Quantidade()
        {
            InitializeComponent();
        }

        private async void OnVoltarButtonClicked(object sender, EventArgs e)
        {
             VoltarButton.Clicked += OnVoltarButtonClicked;
            // Lógica para o botão Voltar
            await Navigation.PopAsync();
        }

        private async void OnProximoButtonClicked(object sender, EventArgs e)
        {
            ProximoButton.Clicked += OnProximoButtonClicked;
            // Lógica para o botão Próximo
            await Navigation.PushAsync(new ProximaPagina());
        }
    }
}
