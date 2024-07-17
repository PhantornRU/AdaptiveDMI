using System.Windows.Controls;

using AdaptiveDMI.ViewModels;

namespace AdaptiveDMI.Views;

public partial class ConfigPage : Page
{
    public ConfigPage(ConfigViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
