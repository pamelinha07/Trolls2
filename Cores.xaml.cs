public partial class Cores : ContentPage
{
    public Cores()
    {
        InitializeComponent();

        VoltarButton.Clicked += OnVoltarButtonClicked;
        ProximoButton.Clicked += OnProximoButtonClicked;
    }

    private void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        // Implement logic for the "Voltar" button
    }

    private void OnProximoButtonClicked(object sender, EventArgs e)
    {
        // Implement logic for the "Próximo" button
    }
}
