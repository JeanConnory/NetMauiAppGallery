namespace AppMauiGallery.Views.Utils;

public partial class PlatformIdiomPage : ContentPage
{
	public PlatformIdiomPage()
	{
		InitializeComponent();

#if WINDOWS
DisplayAlert("Condi��es de compila��o", "Esta mensagem � de condi��o de compila��o", "OK");
#endif

		if (Device.RuntimePlatform == Device.WinUI)
			DisplayAlert("Windows", "Esta mensagem � exclusiva do Windows", "OK");

		if (Device.Idiom == TargetIdiom.Desktop)
			DisplayAlert("Desktop", "Esta mensagem � exclusiva do Desktop/Windows", "OK");
	}
}