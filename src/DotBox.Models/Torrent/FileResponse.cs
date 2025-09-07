using System.Text.Json.Serialization;

namespace DotBox.Models.Torrent;

public class FileResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("md5")]
    public string? Md5 { get; set; }
    
    [JsonPropertyName("hash")]
    public required string Hash { get; set; }
}