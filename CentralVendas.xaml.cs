public partial class CentralVendas : ContentPage
{
    public CentralVendas()
    {
        InitializeComponent();

        VoltarButton.Clicked += OnVoltarButtonClicked;
        PlusButton.Clicked += OnPlusButtonClicked;
        TrashButton.Clicked += OnTrashButtonClicked;
    }

    private void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        // Implement logic for the "Voltar" button
    }

    private void OnPlusButtonClicked(object sender, EventArgs e)
    {
        // Implement logic for the "+" button
    }

    private void OnTrashButtonClicked(object sender, EventArgs e)
    {
        // Implement logic for the "trash" button
    }
}
