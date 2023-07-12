namespace MenuEjercicios;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new NumerosParesPage());
    }

    private void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CuentaRegresivaPage());
    }

    private void ImageButton_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TablaMultiPage());
    }

    private void ImageButton_Clicked_3(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SueldoPage());
    }

    private void ImageButton_Clicked_4(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LangostaPage());
    }

    private void ImageButton_Clicked_5(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Pesos());
    }
}

