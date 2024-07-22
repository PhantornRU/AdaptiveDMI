using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using AdaptiveDMI.Core.Models;
using AdaptiveDMI.ViewModels;

namespace AdaptiveDMI.Views;

public partial class ProcessPage : Page
{
    //[ObservableProperty]
    private ObservableCollection<ModifiableFileDetail> _modifiableFileListViewItems;
    ListViewModifiableFileModel listViewModifiableFileModel = new ListViewModifiableFileModel();

    public ProcessPage(ProcessViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
        _modifiableFileListViewItems = listViewModifiableFileModel.GetModifiableFileDetails();

    }

    private void button_Click(object sender, RoutedEventArgs e)
    {
        //NavigationService.Navigate(typeof(ConfigPage));
        // TODO: Change Window
    }
}
