using AppMauiGallery.Views.Lists.Models;

namespace AppMauiGallery.Views.Lists;

public partial class ListViewPage : ContentPage
{
	public ListViewPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        listViewControl.ItemsSource = MovieList.GetList();
    }

    private void listViewControl_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var movie = (Movie)e.SelectedItem;
        App.Current.MainPage.DisplayAlert("Filme Selecionado", $"O filme selecionado é: {movie.Name}", "OK");
    }
}