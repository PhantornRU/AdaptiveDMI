using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using AdaptiveDMI.Core.Models;
using AdaptiveDMI.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using DMISharp;
using SixLabors.ImageSharp.PixelFormats;

namespace AdaptiveDMI.Views;

public partial class MainPage : Page
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;

        TestFunction();
    }


    private void Button_Click(object sender, RoutedEventArgs e)
    {

    }


    private void TestFunction()
    {

        string path = "TestImages";
        using DMIFile file = new DMIFile($"{path}/testBodyHuman.dmi");

        Debug.WriteLine($"Loaded {file}({file.States.Count}).");

        DMIState stateFirst = file.States.First();


        Canvas canvas = 


        if (file.CanSave())
            file.Save($"{path}/testExport.dmi");
        else
            Debug.WriteLine($"Failed to save {file}.");


        //var sourceData = new List<string>() { "human" };
        //foreach (var source in sourceData)
        //{
        //    var img = Image.Load<Rgba32>($@"Data/Input/SourceImages/{source}.png");
        //    var newState = new DMIState(source, DirectionDepth.One, 1, 32, 32);
            
        //    //newState.SetFrame(img, 0);

        //    //newDMI.AddState(newState);

        //    //newDMI.States.First()
        //}
    }

    private void ExampleFunction()
    {

        //ImageBrush brush = new ImageBrush();
        //brush.ImageSource = new BitmapImage(new Uri(@"image.png", UriKind.Relative));
        //CanvasLeft.Background = brush;



        //    using var fileTest = new DMIFile("test.dmi");



        //    using var fileUns = new DMIFile("unsorted_states.dmi");
        //    fileUns.SortStates();
        //    fileUns.Save("sorted_states.dmi");



        //using var newDMI = new DMIFile(32, 32);
        //var sourceData = new List<string>() { "sord", "sordvert", "steve32" };

        //foreach (var source in sourceData)
        //{
        //    var img = Image.Load<Rgba32>($@"Data/Input/SourceImages/{source}.png");
        //    var newState = new DMIState(source, DirectionDepth.One, 1, 32, 32);
        //    newState.SetFrame(img, 0);
        //    newDMI.AddState(newState);
        //}

        //newDMI.Save(@"Data/Output/minecraft.dmi");

        /*

        using var newDMI = new DMIFile(32, 32);

        // Create state
        var img = Image.Load<Rgba32>($@"Data/Input/SourceImages/steve32.png");
        var newState = new DMIState("steve32", DirectionDepth.One, 1, 32, 32);
        newState.SetFrame(img, 0);
        newDMI.AddState(newState);

        // Modifying state
        newDMI.States.First().SetDirectionDepth(DirectionDepth.Four);
        newDMI.States.First().SetFrameCount(10);

        // At this point you would add the new frames for each direction, otherwise
        // you cannot save the file.

        // Saving
        newDMI.Save(@"Data/Output/minecraft.dmi");
        */
    }
}
