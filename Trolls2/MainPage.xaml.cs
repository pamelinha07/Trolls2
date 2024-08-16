using System.ComponentModel;

namespace Trolls2;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        Setting an image source; 
        Image image = new Image { Source = "scissors_and_thread.png"};
        Content.ChildrenReordered.Insert(1,image);

        // Example: Setting an image source
        // Image image = new Image { Source = "scissors_and_thread.png" };
        // Content.Children.Insert(1, image);
    }
}
