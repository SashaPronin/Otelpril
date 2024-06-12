namespace Otelpril.Pages;

public partial class Registration : ContentPage
{
	public Registration()
	{
        InitializeComponent();
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
                        
                    }
                    else
                    {
                        DisplayAlert("Ошибка", "Введите пароль", "ок");
                    }
                }
                else
                {
                    DisplayAlert("Ошибка", "Введите имя", "ок");
                }
            }
            else
            {
                DisplayAlert("Ошибка", "Введите фамилию", "ок");
            }
        }
        else
        {
            DisplayAlert("Ошибка", "Введите номер телефона. Пример: 89137777777", "ок");
        }
    }
    private async void OnLabelTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

}