namespace AppMauiGallery.Views.Components.Forms;

public partial class StepperPage : ContentPage
{
	public StepperPage()
	{
		InitializeComponent();
	}

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		lblValue.Text = $"Antigo: {e.OldValue} - Novo: {e.NewValue}";

	}
}