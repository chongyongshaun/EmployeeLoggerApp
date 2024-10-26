using EmployeeLoggerApp.Models.ViewModels;

namespace EmployeeLoggerApp.Pages;

public partial class EmployeeListPage : ContentPage
{
	public EmployeeListPage()
	{
		InitializeComponent();

		BindingContext = new EmployeesViewModel();
	}

    private void TextCell_Tapped(object sender, EventArgs e)
    {

    }
}