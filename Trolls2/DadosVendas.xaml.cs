namespace Trolls2;
public partial class DadosVendas : ContentPage
{
    public DadosVendas()
    {
        InitializeComponent();

        VoltarButtonClicked += OnVoltarButtonClicked;
    }

    private void OnVoltarButtonClicked(object sender, EventArgs e)
    {
         VoltarButtonClicked = OnVoltarButtonClicked;
        // Implement logic for the "Voltar" button
    }
}
