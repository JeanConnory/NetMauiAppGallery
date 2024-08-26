namespace AppMauiGallery.Views.Shells.Pages;

public partial class Page01Step01 : ContentPage
{
	public Page01Step01()
	{
		InitializeComponent();
	}   

    private void GoBack(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }

    private void GoStep02(object sender, EventArgs e)
    {
        //Rotas relativas
        Shell.Current.GoToAsync("../page01step02");
    }
}