namespace AppMauiGallery.Views.Animations;

public partial class BasicAnimation : ContentPage
{
	public BasicAnimation()
	{
		InitializeComponent();
	}

    private void Aumentar(object sender, EventArgs e)
    {
        Imagem.ScaleTo(2, 2000);
    }

    private void Diminuir(object sender, EventArgs e)
    {
        Imagem.ScaleTo(0.5, 2000);
    }

    private void Normal(object sender, EventArgs e)
    {
        Imagem.Scale = 1;
        Imagem.Opacity = 1;
        Imagem.TranslationX = 0;
        Imagem.TranslationY = 0;
        Imagem.Rotation = 0;
        Imagem.RotationX = 0;
        Imagem.RotationY = 0;
    }

    private void Mover(object sender, EventArgs e)
    {
        Imagem.TranslateTo(0, 90, 2000, Easing.BounceOut);
    }

    private async void Rotacao(object sender, EventArgs e)
    {
        //await Imagem.RotateTo(720, 2000);
        //await Imagem.RotateXTo(360, 1000);
        await Imagem.RelRotateTo(90, 1000);
    }

    private async void Transparencia(object sender, EventArgs e)
    {
        await Imagem.FadeTo(0.3, 1000);
    }

    private async void Sequencial(object sender, EventArgs e)
    {
       await Imagem.TranslateTo(100, 0, 250);
       await Imagem.TranslateTo(-100, 0, 500);
       await Imagem.TranslateTo(0, 0, 250);
    }

    private async void Paralelo(object sender, EventArgs e)
    {
        await Task.WhenAll(
                Imagem.TranslateTo(100, 0, 3000),
                Imagem.RotateTo(360, 3000),
                Imagem.FadeTo(0.6, 3000)
            );
    }

    private void Cancelamento(object sender, EventArgs e)
    {
        Imagem.CancelAnimations();
    }

    private void Custom(object sender, EventArgs e)
    {
        var principal = new Animation();
        var animacao01 = new Animation(v => Imagem.TranslationX = v, 0, 150, Easing.Linear, null);
        var animacao02 = new Animation(v => Imagem.Rotation = v, 0, 360, Easing.Linear, null);

        principal.Add(0, 1, animacao01);
        principal.Add(0.5, 1, animacao02);

        principal.Commit(this, "AnimacaoPersonalizada", 16, 10000, null, null, null);
        //animacao01.Commit(this, "MoveOCarro", 16, 3000, null, null, repeat: ()=> true);
    }

    private void Cor(object sender, EventArgs e)
    {
        Imagem.ColorTo(Colors.Black, Colors.Violet, v => Imagem.BackgroundColor = v, 2000, null);
    }
}