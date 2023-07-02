namespace Superficie;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void btnCalcular_Clicked(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(b.Text) || (!string.IsNullOrEmpty(a.Text)))
		{
            double bas, alt, superf;

            bas = Convert.ToDouble(b.Text);
            alt = Convert.ToDouble(a.Text);

            superf = (bas * alt) / 2;

            Superf.Text = superf.ToString();
        }
		else
		{
            DisplayAlert("Error", "Ocurrio un error al introducir el dato", "Gracias!");

        }
    }
}

