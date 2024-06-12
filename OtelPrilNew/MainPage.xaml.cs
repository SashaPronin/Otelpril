using OtelPrilNew.Service;

namespace OtelPrilNew
{
    public partial class MainPage : ContentPage
    {
        string user = "";
        public MainPage()
        {
            InitializeComponent();
            Task.Run(async () => {user = await SessionService.GetUserFromSecureStorage(); });
            if (user.Length == 0)
            {
                Navigation.PushAsync(new LoginPage());
            }
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            SessionService.RemoveUserFromSecureStorage();
            Navigation.PushAsync(new LoginPage());
        }
    }

}
