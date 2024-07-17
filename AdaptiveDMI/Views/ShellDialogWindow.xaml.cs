using System.Windows.Controls;

using AdaptiveDMI.Contracts.Views;
using AdaptiveDMI.ViewModels;

using MahApps.Metro.Controls;

namespace AdaptiveDMI.Views;

public partial class ShellDialogWindow : MetroWindow, IShellDialogWindow
{
    public ShellDialogWindow(ShellDialogViewModel viewModel)
    {
        InitializeComponent();
        viewModel.SetResult = OnSetResult;
        DataContext = viewModel;
    }

    public Frame GetDialogFrame()
        => dialogFrame;

    private void OnSetResult(bool? result)
    {
        DialogResult = result;
        Close();
    }
}
