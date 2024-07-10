namespace AppMauiGallery.Views.Components.Forms;

public partial class CheckboxPage : ContentPage
{
	public CheckboxPage()
	{
		InitializeComponent();
	}

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if (e.Value == true)
		{
			CheckBox checkbox = ((CheckBox)sender);
			HorizontalStackLayout stack = (HorizontalStackLayout)checkbox.Parent;
			Label label = (Label)stack.Children[1];
			lblStatus.Text = label.Text;
		}
		else
		{
			lblStatus.Text = string.Empty;
		}
    }
}