namespace OtelPrilNew.Pages;

public partial class HomePage : ContentPage
{
	public HomePage() => InitializeComponent();

    private async void OnImageButtonClicked(object sender, EventArgs e)
    {
        var StarOne = new StarOne();
        await Navigation.PushAsync(StarOne);
    }
}