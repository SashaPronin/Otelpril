namespace OtelPrilNew.Pages;

public partial class StarOne : ContentPage
{

    public StarOne()
    {
        InitializeComponent();
    }

    private async void OnImageButtonClicked(object sender, EventArgs e)
        {
            var description = new description();
            await Navigation.PushAsync(description);
        }
}