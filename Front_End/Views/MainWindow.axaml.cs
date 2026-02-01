using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Front_End.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnCreateInvoiceClick(object? sender, RoutedEventArgs e)
        {
            // Placeholder click handler - currently just show a message box.
            // The project may prefer a ViewModel command; this prevents XAML compile-time error.
            
            var msg = new Window
            {
                Title = "Create Invoice",
                Width = 400,
                Height = 200,
                Content = new TextBlock { Text = "Create Invoice clicked", VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center, HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center }
            };
            msg.ShowDialog(this);
        }
    }
}