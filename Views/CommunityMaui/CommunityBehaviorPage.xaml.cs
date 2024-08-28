using AppMauiGallery.Views.CommunityMaui.ViewModels;

namespace AppMauiGallery.Views.CommunityMaui;

public partial class CommunityBehaviorPage : ContentPage
{
    public CommunityBehaviorPage()
    {
        InitializeComponent();
    }

    private void OnpRessed(object sender, EventArgs e)
    {
        var vm = (CommunityBehaviorPageViewModel)BindingContext;

        if(vm.PressedCommand.CanExecute(null))
            vm.PressedCommand.Execute(null);
    }
}