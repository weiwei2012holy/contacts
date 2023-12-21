using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Contacts.Lib;

namespace Contacts.Views;

public partial class ContactsListView : UserControl
{
    public ContactsListView()
    {
        InitializeComponent();
    }

    private void AddUserHandler(object? sender, RoutedEventArgs e)
    {
        Helper.Dump(e,sender);
    }
}