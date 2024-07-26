using LogRegFirebase.Pages;

namespace LogRegFirebase
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new LoginPage());
        }
    }

}
