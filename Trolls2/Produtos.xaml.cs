using System;
using Microsoft.Maui.Controls;

namespace Trolls2
{
    public partial class Produtos : ContentPage
    {
        public Produtos()
        {
            InitializeComponent();
            
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void OnProximoClicked(object sender, EventArgs e)
        {
            // Lógica para 
        }
    }
}
