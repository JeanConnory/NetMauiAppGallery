using AppMauiGallery.Libraries.Fix;

namespace AppMauiGallery;

public partial class AppFlyout : FlyoutPage
{
	public AppFlyout()
	{
		InitializeComponent();
	}

    private void FlyoutPage_IsPresentedChanged(object sender, EventArgs e)
    {
        KeyboardFix.HideKeyboard();
    }
}