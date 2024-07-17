using System.Windows.Controls;

using AdaptiveDMI.ViewModels;

namespace AdaptiveDMI.Views;

public partial class ProcessPage : Page
{
    public ProcessPage(ProcessViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
