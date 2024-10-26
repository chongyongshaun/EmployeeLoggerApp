using CommunityToolkit.Mvvm.ComponentModel;

namespace EmployeeLoggerApp.Models.ViewModels
{
    internal partial class EmployeeDetailViewModel2 : ObservableObject
    {
        [ObservableProperty]
        private Employee emp;
    }
}
