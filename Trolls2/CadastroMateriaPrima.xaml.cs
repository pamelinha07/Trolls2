namespace Trolls2;
public partial class CadastroMateriaPrima : ContentPage
{
    public CadastroMateriaPrima()
    {
        InitializeComponent();
         
        //CancelarButton.Clicked += OnCancelarButtonClicked;
       // SalvarAlteracoesButton.Clicked += OnSalvarAlteracoesButtonClicked;
    }

    private void OnCancelarButtonClicked(object sender, EventArgs e)
    {
        CancelarButtonClicked = OnCancelarButtonClicked;
        // Implement logic for the "Cancelar" button
    }

    private void OnSalvarAlteracoesButtonClicked(object sender, EventArgs e)
    {
         SalvarAlteracoesButtonClicked = OnSalvarAlteracoesButtonClicked;
        // Implement logic for the "Salvar alterações" button
    }
}
