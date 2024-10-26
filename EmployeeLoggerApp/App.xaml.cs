using EmployeeLoggerApp.Pages;

namespace EmployeeLoggerApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EmployeeListPage());
        }
    }
}
