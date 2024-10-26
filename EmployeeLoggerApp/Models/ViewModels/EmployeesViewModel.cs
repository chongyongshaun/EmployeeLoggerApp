using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace EmployeeLoggerApp.Models.ViewModels;

internal partial class EmployeesViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Employee> emps = [];

    [ObservableProperty]
    private Employee? emp = new();

    [RelayCommand] //automatically generates a Ad dCommand command for us to bind
    private void Add()
    {
        Emps.Add(Emp);
        //assign emp to a new empolyee object 
        Emp = new();
    } 
}
