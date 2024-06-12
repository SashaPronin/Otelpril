using Otelpril.Properties.Services;

namespace Otelpril.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();

    }

    private async void ButtonLogin_Clicked(object sender, EventArgs e)
    {
        if (LoginNumber.Text.Length == 11)
        {
            if (LoginPassword.Text.Length > 0)
            {
                
            }
            else
            {
                DisplayAlert("ќшибка", "¬ведите пароль", "ок");
            }
        }
        else
        {
            DisplayAlert("ќшибка", "¬ведите номер телефона", "ок");
        }

    }
}