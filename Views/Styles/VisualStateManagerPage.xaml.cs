namespace AppMauiGallery.Views.Styles;

public partial class VisualStateManagerPage : ContentPage
{
	public VisualStateManagerPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		var label = (Label)sender;
		VisualStateManager.GoToState(label, "Tapped");
    }
}