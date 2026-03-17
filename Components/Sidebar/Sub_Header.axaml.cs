using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ERP_APP.Components.Sidebar
{
    public partial class Sub_Header : UserControl
    {
        public Sub_Header()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}