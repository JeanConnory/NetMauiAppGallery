namespace AppMauiGallery.Views.Shells.Pages;

public partial class Page01Step02 : ContentPage
{
	public Page01Step02()
	{
		InitializeComponent();
	}

    private void GoToRegisterStep02(object sender, EventArgs e)
    {
		//Rota absoluta
		Shell.Current.GoToAsync("//cadastro/passo02");
    }

    private void GoToRegisterStep01(object sender, EventArgs e)
    {
        //Rota pesquisando na árvore de rotas
        Shell.Current.GoToAsync("///passo01");
    }
}