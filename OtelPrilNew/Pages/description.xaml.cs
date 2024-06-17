namespace OtelPrilNew.Pages;

public partial class description : ContentPage
{
	public description()
	{
		InitializeComponent();
	}
    private async void OnButtonClicked(object sender, EventArgs e)
    {
        var FavoritesPage = new FavoritesPage();
        await Navigation.PushAsync(FavoritesPage);
    }
}