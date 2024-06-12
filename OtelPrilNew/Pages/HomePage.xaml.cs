namespace OtelPrilNew.Pages;

public partial class HomePage : ContentPage
{
	public HomePage() => InitializeComponent();

    private async void OnImageButtonClicked(object sender, EventArgs e)
    {
        var nextPage = new NextPage(StarOne);
        await Navigation.PushAsync(nextPage);
    }
}