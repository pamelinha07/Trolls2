using System;
using Microsoft.Maui.Controls;

namespace Produtos
{
    public partial class Produtos : ContentPage
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
             VoltarButton.Clicked += OnVoltarButtonClicked;
            // Lógica para voltar
        }

        private void OnProximoClicked(object sender, EventArgs e)
        {
             ProximoButton.Clicked += OnProximoButtonClicked;
            // Lógica para próximo
        }
    }
}
