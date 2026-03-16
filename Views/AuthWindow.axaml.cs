using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using ERP_APP;

namespace ERP_APP.Views;

public partial class AuthWindow : Window
{
    public AuthWindow()
    {
        InitializeComponent();
    }

    private void OnLoginButtonClick(object sender, RoutedEventArgs e)
    {
        if (Application.Current is App app)
        {
            app.OnLoginSuccess();
        }
    }
}