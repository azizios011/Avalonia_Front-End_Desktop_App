using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ERP_APP.Views;

public partial class AuthWindow : Window
{
    public AuthWindow()
    {
        InitializeComponent();
    }

    private void OnLoginButtonClick(object sender, RoutedEventArgs e)
    {
        ((App)App.Current).OnLoginSuccess();
    }
}