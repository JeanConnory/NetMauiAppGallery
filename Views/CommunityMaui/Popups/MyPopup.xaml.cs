using CommunityToolkit.Maui.Views;

namespace AppMauiGallery.Views.CommunityMaui.Popups;

public partial class MyPopup : Popup
{
	public MyPopup()
	{
		InitializeComponent();
	}

    private void OnClickedClose(object sender, EventArgs e)
    {
		this.Close();
    }

    private void OnClickSaveEmailAndClose(object sender, EventArgs e)
    {
        //Salvaria o e-mail
        this.Close();
    }
}