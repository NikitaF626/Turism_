using System.IO;

public class MapModel
{
    public string ApiKey { get; set; } = "030a3c7d-a324-4514-89b0-a771b08a1810";
    public Uri HtmlPath { get; }

    public MapModel()
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        HtmlPath = new Uri(System.IO.Path.Combine(currentDirectory, "Resources", "Map.html"));
    }
}
