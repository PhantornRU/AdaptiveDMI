using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

using CommunityToolkit.Mvvm.ComponentModel;
using AdaptiveDMI.Core.Models;

namespace AdaptiveDMI.ViewModels;

public partial class ListViewModifiableFileModel : ObservableObject 
{
    private int _listViewSelectionModeComboBoxSelectedIndex = 0;

    public int ListViewSelectionModeComboBoxSelectedIndex
    {
        get => _listViewSelectionModeComboBoxSelectedIndex;
        set
        {
            SetProperty<int>(ref _listViewSelectionModeComboBoxSelectedIndex, value);
            UpdateListViewSelectionMode(value);
        }
    }

    [ObservableProperty]
    private SelectionMode _listViewSelectionMode = SelectionMode.Single;

    public ObservableCollection<ModifiableFileDetail> GetModifiableFileDetails()
    {
        // Здесь должен быть "доставатель" конфига, а не генератор
        return GenerateModifiableFileDetails();
    }

    private ObservableCollection<ModifiableFileDetail> GenerateModifiableFileDetails()
    {
        var random = new Random();
        var ModifiableFileDetails = new ObservableCollection<ModifiableFileDetail>();

        var names = new[]
        {
            "John",
            "Winston",
            "Adrianna",
            "Spencer",
            "Phoebe",
            "Lucas",
            "Carl",
            "Marissa",
            "Brandon",
            "Antoine",
            "Arielle",
            "Arielle",
            "Jamie",
            "Alexander"
        };
        var filenames = new[]
        {
            "SpriteDoe",
            "SpriteTapia",
            "SpriteCisneros",
            "SpriteLynch",
            "SpriteMunoz",
            "SpriteMarsh",
            "SpriteHudson",
            "SpriteBartlett",
            "SpriteGregory",
            "SpriteBanks",
            "SpriteHood",
            "SpriteFry",
            "SpriteCarroll"
        };

        for (int i = 0; i < 50; i++)
            ModifiableFileDetails.Add(
                new ModifiableFileDetail(
                    names[random.Next(0, names.Length)],
                    filenames[random.Next(0, filenames.Length)]
                )
            );

        return ModifiableFileDetails;
    }

    private void UpdateListViewSelectionMode(int selectionModeIndex)
    {
        ListViewSelectionMode = selectionModeIndex switch
        {
            1 => SelectionMode.Multiple,
            2 => SelectionMode.Extended,
            _ => SelectionMode.Single
        };
    }
}
