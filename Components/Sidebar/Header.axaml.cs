using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ERP_APP.Components.Sidebar
{
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}