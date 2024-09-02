namespace Trolls2;
public partial class CadastroCostureiro : ContentPage
{
    public CadastroCostureiro()
    {
        InitializeComponent();
    }

    private void OnCancelarButtonClicked(object sender, EventArgs e)
    {
        // Implement logic for the "Cancelar" button
    }

    private void OnSalvarAlteracoesButtonClicked(object sender, EventArgs e)
    {
        // Implement logic for the "Salvar alterações" button
    }

    void VoltarClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new MainPage();
    }
}
