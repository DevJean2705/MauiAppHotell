namespace MauiAppHotell.Views;

public partial class SobreHotell : ContentPage
{
	public SobreHotell()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new ContratacaoHospedagem());

		} catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
    }
}