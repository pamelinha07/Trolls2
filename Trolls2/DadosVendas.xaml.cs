namespace Trolls2;
public partial class DadosVendas : ContentPage
{
    public DadosVendas()
    {
        InitializeComponent();

    }

    private void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new MainPage();
    }
}
