using EmployeeLoggerApp.Models.ViewModels;

namespace EmployeeLoggerApp.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}


    private void Employee1Button_Clicked(object sender, EventArgs e)
    {
        //var emp1ViewModel = new EmployeeDetailViewModel2
        //{
        //    EmployeeName = "Test",
        //    Email = "test@email.com",
        //    EmployeeId = "1234",
        //    IsPartTimer = true
        //};
        //var detailPage = new EmployeeDetailPage();
        //detailPage.BindingContext = emp1ViewModel;
        //Navigation.PushAsync(detailPage);

    }

    private void Employee2Button_Clicked(object sender, EventArgs e)
    {
        //var detailPage = new EmployeeDetailPage
        //{
        //    BindingContext = new EmployeeDetailViewModel2
        //    {
        //        EmployeeName = "Bob Odenkirk",
        //        Email = "bob@gmail.com",
        //        EmployeeId = "1001",
        //        IsPartTimer = false
        //    }
        //};
        //Navigation.PushAsync(detailPage);
    }
}