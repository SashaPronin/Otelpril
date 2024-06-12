using OtelPrilNew.Pages;
using OtelPrilNew.Service;

namespace OtelPrilNew;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
        string user = "";
        InitializeComponent();
        Task.Run(async () => { user = await SessionService.GetUserFromSecureStorage(); });
        if (user.Length > 0)
        {
            Navigation.PushAsync(new HomePage());
        }
	}

    private async void ButtonLogin_Clicked(object sender, EventArgs e)
    {
        if (LoginNumber.Text.Length > 0)
        {
            if (LoginPassword.Text.Length > 0)
            {
            if(await UserService.Auth(LoginNumber.Text, LoginPassword.Text))
                {
                    DisplayAlert("�������", "�� ������� ������������", "��");
                    Navigation.PushAsync(new MainPage());
                }
                else
                {
                    DisplayAlert("������", "��� ����������� ��������� ������", "��");
                }
            }
            else
            {
                DisplayAlert("������", "������� ������", "��");
            }
        }
        else
        {
            DisplayAlert("������", "������� ����� ��������", "��");
        }

    }

}