using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace AppMauiGallery.Views.CommunityMaui;

public partial class AlertPage : ContentPage
{
	public AlertPage()
	{
		InitializeComponent();
	}

    private void OnButtonClicked_ShowSnackbar(object sender, EventArgs e)
    {
		//Configura��o visual
		var options = new SnackbarOptions
		{
			BackgroundColor = Colors.White,
			TextColor = Colors.Green
		};

		//Cria��o do objeto
		var snackBar = Snackbar.Make("Ocorreu um erro inesperado!", null, "OK", TimeSpan.FromSeconds(5), options);

		//Apresenta��o da Snack
		snackBar.Show();
    }

    private void OnButtonClicked_ShowToast(object sender, EventArgs e)
    {
		var toast = Toast.Make("Ocorreu um erro inesperado", ToastDuration.Long, 16);

		toast.Show();
    }
}