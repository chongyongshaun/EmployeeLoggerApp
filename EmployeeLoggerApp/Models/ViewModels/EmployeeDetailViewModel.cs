using System.ComponentModel;

namespace EmployeeLoggerApp.Models.ViewModels;

internal class EmployeeDetailViewModel : INotifyPropertyChanged
{
    public string? EmployeeId { get; set; }
    
    //employee Name will be made responsive to change as an example
    private string? employeeName;
    public string? EmployeeName {
        get {  return employeeName; } 
        set 
        {
            employeeName = value;
            NotifyPropertyChanged(nameof(EmployeeName));
        }
    }
    public string? Email { get; set; }
    public bool IsPartTimer { get; set; }

    //inheriteed from the inotify class
    public event PropertyChangedEventHandler? PropertyChanged;
    //create a function to handle the change of event for said property
    private void NotifyPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }    
}
