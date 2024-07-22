using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using AdaptiveDMI.Core.Models;
using AdaptiveDMI.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AdaptiveDMI.Views;

public partial class MainPage : Page
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {

    }
}
