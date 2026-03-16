using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using System.Linq;
using Avalonia.Markup.Xaml;
using ERP_APP.ViewModels;
using ERP_APP.Views;

namespace ERP_APP;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new AuthWindow();
        }
        base.OnFrameworkInitializationCompleted();
    }

    public void OnLoginSuccess()
    {
        var dashboard = new DashBoard();
        dashboard.Show();
        this.Close(); // closes the auth window
    }

    private void Close()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow?.Close();
        }
    }
}