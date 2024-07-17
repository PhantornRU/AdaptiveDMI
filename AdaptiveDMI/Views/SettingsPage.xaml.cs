using System.Windows.Controls;

using AdaptiveDMI.ViewModels;

namespace AdaptiveDMI.Views;

public partial class SettingsPage : Page
{
    public SettingsPage(SettingsViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
