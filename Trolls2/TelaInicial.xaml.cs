using System.ComponentModel;

namespace Trolls2;

public partial class TelaInicial : ContentPage
{
    public TelaInicial()
    {
        InitializeComponent();
    }

    public void OnClientesClicked(object sender, EventArgs args)
    {
        Application.Current.MainPage = new TelaInicial();
    }
}
