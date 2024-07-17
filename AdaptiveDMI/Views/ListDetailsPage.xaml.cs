using System.Windows.Controls;

using AdaptiveDMI.ViewModels;

namespace AdaptiveDMI.Views;

public partial class ListDetailsPage : Page
{
    public ListDetailsPage(ListDetailsViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
