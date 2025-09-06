using System.Text.Json.Serialization;

namespace DotBox.Models;

public class ErrorDetail
{
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("loc")]
    public IEnumerable<string> Loc { get; set; } = [];

    [JsonPropertyName("msg")]
    public required string Msg { get; set; }

    [JsonPropertyName("input")]
    public required string Input { get; set; }
}