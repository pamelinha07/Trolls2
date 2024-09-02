using System.ComponentModel;

namespace Trolls2;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();


        
        // Example: Setting an image source
        // Image image = new Image { Source = "scissors_and_thread.png" };
        // Content.Children.Insert(1, image);
    }
    void ClientesClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new CadastroCliente();
    }

    void ProdutosClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Produtos();
    }

    void VendasClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new CentralVendas();
    }

    
}
