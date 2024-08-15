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
        VoltarButton.Clicked += OnVoltarButtonClicked; OnVoltarButtonClicked(sender,) {
            VoltarButtonCliked.Enabled = true;
        }
        
    }

    private void OnPlusButtonClicked(object sender, EventArgs e)
    {
         PlusButton.Clicked += OnPlusButtonClicked; OnPlusButtonClicked(sender,) {
            PlusButtonClicked.Enabled = true;
         }
        
    }

    private void OnTrashButtonClicked(object sender, EventArgs e)
    {
      TrashButton.Clicked += OnTrashButtonClicked; OnTrashButtonClicked(sender,) {
        TrashButtonCliked.Disabled = true;
      }

    
       
    }
}
