using Otelpril.Properties.Services;

namespace Otelpril.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();

        if (UserService.UserAuth())
        {
            Navigation.PushAsync(new ProfilePage());
        }

    }

    private async void ButtonLogin_Clicked(object sender, EventArgs e)
    {
        if (LoginNumber.Text.Length == 11)
        {
            if (LoginPassword.Text.Length > 0)
            {
                var id = await UserService.Auth(new() { Number = LoginNumber.Text, Password = LoginPassword.Text });
                if (id > 0)
                {
                    await SecureStorage.SetAsync("id", id.ToString());
                    Navigation.PushAsync(new ProfilePage());

                }
                else
                {
                    DisplayAlert("Ошибка", "Номер или пароль неверный", "ок");
                }
            }
            else
            {
                DisplayAlert("Ошибка", "Введите пароль", "ок");
            }
        }
        else
        {
            DisplayAlert("Ошибка", "Введите номер телефона", "ок");
        }

    }
}