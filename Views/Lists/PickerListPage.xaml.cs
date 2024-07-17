using AppMauiGallery.Views.Lists.Models;

namespace AppMauiGallery.Views.Lists;

public partial class PickerListPage : ContentPage
{
	public PickerListPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {		
		PickerControl.ItemsSource = MovieList.GetList();

		PickerControl.SelectedIndex = 3;
    }
}