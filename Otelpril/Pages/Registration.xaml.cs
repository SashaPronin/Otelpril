namespace Otelpril.Pages;

public partial class Registration : ContentPage
{
	public Registration()
	{
        InitializeComponent();
        if (UserService.UserAuth())
        {
            Navigation.PushAsync(new ProfilePage());

        }
    }

    private async void ButtonAccReg_Clicked(object sender, EventArgs e)
    {
        if (PhoneNumberReg.Text.Length == 11)
        {
            if (SecondNameReg.Text.Length > 0)
            {
                if (NameReg.Text.Length > 0)
                {
                    if (PassReg.Text.Length > 0)
                    {
                        if (await Service.UserService.RegUser(new() { PhoneNumber = PhoneNumberReg.Text, SecondName = SecondNameReg.Text, UserName = NameReg.Text, Password = PassReg.Text, Basket = { } }))
                        {
                            DisplayAlert(Title, "������� ������", "ok");
                            Navigation.PushAsync(new ProfilePage());
                        }
                        else
                        {
                            DisplayAlert("������", "����� ��� �����", "��");
                        }
                    }
                    else
                    {
                        DisplayAlert("������", "������� ������", "��");
                    }
                }
                else
                {
                    DisplayAlert("������", "������� ���", "��");
                }
            }
            else
            {
                DisplayAlert("������", "������� �������", "��");
            }
        }
        else
        {
            DisplayAlert("������", "������� ����� ��������. ������: 89137777777", "��");
        }
    }
    private async void OnLabelTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

}