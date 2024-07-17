using System.Windows.Controls;

using AdaptiveDMI.ViewModels;

namespace AdaptiveDMI.Views;

public partial class MainPage : Page
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
