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
             VoltarButtonClicked = OnVoltarButtonClicked;
            // Lógica para o botão Voltar
            await Navigation.PopAsync();
        }

        private async void OnProximoButtonClicked(object sender, EventArgs e)
        {
            ProximoButtonClicked = OnProximoButtonClicked;
            // Lógica para o botão Próximo
            await Navigation.PushAsync(new ProximaPagina());
        }
    }
}
