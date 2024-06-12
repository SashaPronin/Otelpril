using Otelpril.Pages;

namespace Otelpril
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

           
            Routing.RegisterRoute(nameof(StarOne), typeof(StarOne));
            Routing.RegisterRoute(nameof(ListingPage), typeof(ListingPage));
            Routing.RegisterRoute(nameof(LoadingPage), typeof(LoadingPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
        }   

    }
    
}
