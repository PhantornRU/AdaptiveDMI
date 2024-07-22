namespace AdaptiveDMI.Core.Models;

/// <summary>
/// Saved configuration for adapt DMI sprites
/// </summary>
public record ConfigDetail
{
    public string ConfigName { get; set; }

    public string FileName { get; set; }

    public string Name => "Config: " + ConfigName;


    public ConfigDetail(string _configName, string _fileName)
    {
        ConfigName = _configName;
        FileName = _fileName;
    }

}