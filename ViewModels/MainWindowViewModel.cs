using Contacts.Services;

namespace Contacts.ViewModels;

public class MainWindowViewModel : ViewModelBase
{


    public MainWindowViewModel()
    {
        var service = new ContactsUserService();
        Users = new ContactsViewModel(service.GetUsers());

    }
    public ContactsViewModel Users { get; }


    
    
}
