public partial class DadosVendas : ContentPage
{
    public DadosVendas()
    {
        InitializeComponent();

        VoltarButton.Clicked += OnVoltarButtonClicked;
    }

    private void OnVoltarButtonClicked(object sender, EventArgs e)
    {
         VoltarButton.Clicked += OnVoltarButtonClicked;
        // Implement logic for the "Voltar" button
    }
}
