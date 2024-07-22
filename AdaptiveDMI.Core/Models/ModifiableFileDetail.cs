namespace AdaptiveDMI.Core.Models;

/// <summary>
/// Saved configuration for adapt DMI sprites
/// </summary>
public record ModifiableFileDetail
{
    public string ModifiableFileName { get; set; }

    public string FileName { get; set; }

    public string Name => "ModifiableFile: " + ModifiableFileName;


    public ModifiableFileDetail(string _modifiableFileName, string _fileName)
    {
        ModifiableFileName = _modifiableFileName;
        FileName = _fileName;
    }

}