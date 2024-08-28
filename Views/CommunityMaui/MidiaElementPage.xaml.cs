namespace AppMauiGallery.Views.CommunityMaui;

public partial class MidiaElementPage : ContentPage
{
	public MidiaElementPage()
	{
		InitializeComponent();
	}

    private void OnClickedToPlay(object sender, EventArgs e)
    {
		Player.Play();

		//Player.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Playing;

		Player.Pause();
    }
}