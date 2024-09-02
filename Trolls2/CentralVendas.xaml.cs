namespace Trolls2;
public partial class CentralVendas : ContentPage
{
    public CentralVendas()
    {
        InitializeComponent();
    }

    private void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new MainPage();
    }

    private void OnPlusButtonClicked(object sender, EventArgs e)
    {
    }

    private void OnTrashButtonClicked(object sender, EventArgs e)
    {

    
       
    }
}
