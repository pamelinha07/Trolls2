using System;
using Microsoft.Maui.Controls;

namespace Trolls2
{
    public partial class Contato: ContentPage
    {
        public Contato()
        {
            InitializeComponent();
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
             VoltarButtonClicked = OnVoltarButtonClicked;
            // Lógica para voltar
        }

        private void OnProximoClicked(object sender, EventArgs e)
        {
             ProximoButtonClicked = OnProximoButtonClicked;
        
            // Lógica para próximo
        }
    }
}
