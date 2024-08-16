namespace Trolls2;
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
        VoltarButtonClicked = OnVoltarButtonClicked; OnVoltarButtonClicked(sender,) {
            VoltarButtonClikedEnabled = true;
        }
        
    }

    private void OnPlusButtonClicked(object sender, EventArgs e)
    {
         PlusButtonClicked = OnPlusButtonClicked; OnPlusButtonClicked(sender,) {
            PlusButtonClicked.Enabled = true;
         }
        
    }

    private void OnTrashButtonClicked(object sender, EventArgs e)
    {
      TrashButtonClicked += OnTrashButtonClicked; OnTrashButtonClicked(sender,) {
        TrashButtonCliked.Disabled = true;
      }

    
       
    }
}
