using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Contacts.Lib;
using Contacts.Models;

namespace Contacts.ViewModels;

public class ContactsViewModel
{
    public ContactsViewModel(IEnumerable<ContactsUser> items)
    {
        Users = new ObservableCollection<ContactsUser>((IEnumerable<ContactsUser>)items);

    }
    
    public ObservableCollection<ContactsUser> Users { get; }


    public void AddContact()
    {
        System.Console.WriteLine("AddContact...");
    }
}