using EmployeeLoggerApp.Models;
using EmployeeLoggerApp.Models.ViewModels;

namespace EmployeeLoggerApp.Pages;

public partial class EmployeeListPage : ContentPage
{
	public EmployeeListPage()
	{
		InitializeComponent();

		BindingContext = new EmployeesViewModel();
	}

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		var emp = (Employee) e.Item;
		//create a new instance of viewmodel obj with the acquired emp data from e.Item
		var employeeDetailViewModel2 = new EmployeeDetailViewModel2 { Emp = emp};
		var employeeDetailPage = new EmployeeDetailPage();
		employeeDetailPage.BindingContext = employeeDetailViewModel2;

		Navigation.PushAsync(employeeDetailPage);
    }
}