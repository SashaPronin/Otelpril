using OtelPrilNew.Service;

namespace OtelPrilNew.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

    private void LogOutButton_Clicked(object sender, EventArgs e)
    {
        SessionService.RemoveUserFromSecureStorage();
        Navigation.PushAsync(new LoginPage());
    }
}