using System;
using Microsoft.Maui.Controls;

namespace Contato
{
    public partial class Contato: ContentPage
    {
        public Contato()
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
