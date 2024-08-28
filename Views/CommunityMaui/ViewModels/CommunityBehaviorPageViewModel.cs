﻿using System.Windows.Input;

namespace AppMauiGallery.Views.CommunityMaui.ViewModels;

public class CommunityBehaviorPageViewModel
{
    public ICommand PressedCommand {  get; set; }

    public CommunityBehaviorPageViewModel()
    {
        PressedCommand = new Command(Pressed);
    }

    private void Pressed()
    {
        App.Current.MainPage.DisplayAlert("Fui pressionado!", "Fui pressionado!", "Ok");
    }
}
