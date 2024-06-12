namespace Otelpril.Pages;

public partial class SearchPage1 : ContentPage
{

    public SearchPage1() => InitializeComponent();

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("StarOne");
    }
}

