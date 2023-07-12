namespace MenuEjercicios;

public partial class NumerosParesPage : ContentPage
{
    /// <summary>
    /// <Createdate>7/7/2023</Createdate>
    /// <Company>USB Technology</Company>
    /// <Lastmodificationdate>7/7/2023</Lastmodificationdate>
    /// <Lastmodificationdescription>Se agrego un DisplayAlert que imprime los numeros pares</Lastmodificationdescription>
    /// <Lastmodificationautor>Lorena Vazquez,Nery Méndez</Lastmodificationautor>
    /// </summary>

    /// <summary>Constructor de la clase</summary>
    public NumerosParesPage()
	{
		InitializeComponent();
	}

    /// <summary>En el evento del boton se encarga de determinar que numeros son pares y cuales no</summary>
    private void Button_Clicked(object sender, EventArgs e)
    {
        // Declaramos las variables correspondientes y realizamos la operación //

        int x = 0;

        while (x < 100)

        {

            x++;

            x = x + 1;

            DisplayAlert("Los numeros pares son:", x.ToString(), "Aceptar");

        }
    }
}