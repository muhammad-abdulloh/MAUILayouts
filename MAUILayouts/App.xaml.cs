using MAUILayouts.Pages;

namespace MAUILayouts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();

            var navigationPage = new NavigationPage(new StackLayoutDemo());
            MainPage = navigationPage;
        }
    }
}
