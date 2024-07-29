public partial class CadastroMateriaPrima : ContentPage
{
    public CadastroMatriaPrima()
    {
        InitializeComponent();

        CancelarButton.Clicked += OnCancelarButtonClicked;
        SalvarAlteracoesButton.Clicked += OnSalvarAlteracoesButtonClicked;
    }

    private void OnCancelarButtonClicked(object sender, EventArgs e)
    {
        // Implement logic for the "Cancelar" button
    }

    private void OnSalvarAlteracoesButtonClicked(object sender, EventArgs e)
    {
        // Implement logic for the "Salvar alterações" button
    }
}
