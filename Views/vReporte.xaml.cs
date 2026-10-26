namespace repasoS4.Views;

public partial class vReporte : ContentPage
{
	public vReporte(string nombre, string carrera, string nivel, string usuario)
	{
		InitializeComponent();
		DisplayAlertAsync("BIENVENIDO", usuario, "OK");
		lblNombre.Text = "Desarrollado por: " + nombre;
		lblCarrera.Text = "Carrera: " + carrera;
		lblNivel.Text = "Nivel:" + nivel;
		//NUMERICO . OPERACION
	}

    private void btnImprimir_Clicked(object sender, EventArgs e)
    {

    }
}