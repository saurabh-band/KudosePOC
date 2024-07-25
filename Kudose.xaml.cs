namespace KudosePOC;
using KudosePOC.ViewModels;
using Plugin.Maui.SegmentedControl;

public partial class Kudose : ContentPage
{
    public Kudose()
    {
        InitializeComponent();
    }

    private void Handle_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        BindingContext = new KudosViewModel()
        {
            SelectedSegmentIndex = e.NewValue,
        };
    }
}