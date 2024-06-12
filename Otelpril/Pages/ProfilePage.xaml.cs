using Otelpril.Properties.Services;

namespace Otelpril.Pages;

public partial class ProfilePage : ContentPage
{
    private readonly AuthService _authService;
    public ProfilePage(AuthService authService)
	{
		InitializeComponent();
		_authService = authService;
	}	
	private void Button_Clicked(object sender, EventArgs e)
	{
		_authService.Logout();
		Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }

    private void ChooseAvatar_Clicked(object sender, EventArgs e)
    {

    }

    private void LogOut_Clicked(object sender, EventArgs e)
    {

    }
}