using Avalonia.Controls;

namespace ERP_APP.Layout;

public partial class Main : UserControl
{
    public Main()
    {
        InitializeComponent();
        // Inject the ledger page into the presenter
        PageContentPresenter.Content = new Pages.GeneralLedger();
    }
}