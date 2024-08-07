using AppMauiGallery.Repositories;

namespace AppMauiGallery.Views;

public partial class Menu : ContentPage
{
    private IGroupComponentRepository _repository;

	public Menu()
	{
		InitializeComponent();

        _repository = new GroupComponentRepository();

        MenuCollection.ItemsSource = _repository.GetGroupComponent(); 

        #region forma antiga
        //var categories = new CategoryRepository().GetCategories();

        //foreach (var category in categories)
        //{
        //          var lblCategory = new Label();
        //          lblCategory.Text = category.Name;
        //	lblCategory.FontFamily = "OpenSansSemibold";


        //          MenuContainer.Children.Add(lblCategory);

        //	foreach (var component in category.Components)
        //	{
        //		var tap = new TapGestureRecognizer();
        //		tap.CommandParameter = component.Page;
        //              tap.Tapped += OnTapComponent;

        //		var lblComponentTitle = new Label();
        //		lblComponentTitle.Text = component.Title;
        //		lblComponentTitle.FontFamily = "OpenSansSemibold";
        //		lblComponentTitle.Margin = new Thickness(20, 20, 0, 0);
        //		lblComponentTitle.GestureRecognizers.Add(tap);

        //              var lblComponentDescription = new Label();
        //		lblComponentDescription.Text = component.Description;
        //              lblComponentDescription.Margin = new Thickness(20, 0, 0, 0);
        //              lblComponentDescription.GestureRecognizers.Add (tap);

        //              MenuContainer.Children.Add(lblComponentTitle);
        //		MenuContainer.Children.Add(lblComponentDescription);
        //	}
        //}
        #endregion
    }

    private void OnTapComponent(object sender, TappedEventArgs e)
    {
		var page = (Type)e.Parameter;
		
		((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(page)); //Mudança para a página
        ((FlyoutPage)App.Current.MainPage).IsPresented = false; //Esconder o menu lateral flyout
    }

    private void OnTapInicio(object sender, TappedEventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new MainPage()); 
        ((FlyoutPage)App.Current.MainPage).IsPresented = false; 
    }
}