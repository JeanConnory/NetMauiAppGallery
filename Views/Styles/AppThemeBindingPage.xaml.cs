namespace AppMauiGallery.Views.Styles;

public partial class AppThemeBindingPage : ContentPage
{
	public AppThemeBindingPage()
	{
		InitializeComponent();

		//Ler o tema
		var theme = Application.Current.RequestedTheme;

		//Mudar o tema
		Application.Current.UserAppTheme = AppTheme.Light;
	}
}