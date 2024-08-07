using AppMauiGallery.Libraries.Fix;
using AppMauiGallery.Models;
using AppMauiGallery.Repositories;
using System.Collections.ObjectModel;

namespace AppMauiGallery.Views;

public partial class MainPage : ContentPage
{
    private IGroupComponentRepository _repository;
    private List<Component> _fullList;
    private ObservableCollection<Component> _filtedList;

	public MainPage()
	{
		InitializeComponent();

        _repository = new GroupComponentRepository();

        _fullList = _repository.GetComponents();
        _filtedList = new ObservableCollection<Component>(_fullList);
        ComponentCollection.ItemsSource = _filtedList;
	}

    private void OnTapComponent(object sender, TappedEventArgs e)
    {
        KeyboardFix.HideKeyboard();
        var page = (Type)e.Parameter;

        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(page)); //Mudan�a para a p�gina
        ((FlyoutPage)App.Current.MainPage).IsPresented = false; //Esconder o menu lateral flyout
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        var word = e.NewTextValue;
        Clear();
        Search(word);
    }

    private void Clear()
    {
        var limit = _filtedList.Count;
        for (int i = 0; i < limit; i++) 
        {
            _filtedList.RemoveAt(0);   
        }
    }

    private void Search(string word)
    {
        var filtedList = _fullList.Where(a => a.Title.ToLower().Contains(word.ToLower())).ToList();

        foreach (var component in filtedList)
        {
            _filtedList.Add(component);
        }
    }
}