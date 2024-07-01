namespace AppMauiGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppFlyout(); //Aqui ele aponta para o arquivo e tipo de pagina será no app
        }
    }
}
