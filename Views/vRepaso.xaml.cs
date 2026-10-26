namespace repasoS4.Views;

public partial class vRepaso : ContentPage
{
	public vRepaso()
	{
		InitializeComponent();
        txtNombre.Text = "Renato";
        txtCarrera.Text = "Sistemas";
        txtNivel.Text = "Octavo";
	}

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new vReporte(txtNombre.Text, txtCarrera.Text, txtNivel.Text, txtUsuario.Text));
		}
		catch (Exception ex)
		{
			//opcional 
		
		}
    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {

    }
}