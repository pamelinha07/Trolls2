public partial class FinalizarPedido : ContentPage
{
    public FinalizarPedido()
    {
        InitializeComponent();

        SimButton.Clicked += OnSimButtonClicked;
        NaoButton.Clicked += OnNaoButtonClicked;
        VoltarButton.Clicked += OnVoltarButtonClicked;
    }

    private void OnSimButtonClicked(object sender, EventArgs e)
    {
        // Implement logic for the "Sim" button
    }

    private void OnNaoButtonClicked(object sender, EventArgs e)
    {
        // Implement logic for the "Não" button
    }

    private void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        // Implement logic for the "Voltar" button
    }
}
