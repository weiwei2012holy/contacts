using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Contacts.Lib;

namespace Contacts.Views;

public partial class DemoVIew : UserControl
{
    public DemoVIew()
    {
        InitializeComponent();
    }

    private void RepeatButtonClickHandler(object? sender, RoutedEventArgs e)
    {
        // RepeatButtonMessage.Text += "\rButton clicked!";
        Helper.Dump("Button clicked!");
    }
}