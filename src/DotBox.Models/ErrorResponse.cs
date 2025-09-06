using System.Text.Json.Serialization;

namespace DotBox.Models;

public class ErrorResponse
{
    [JsonPropertyName("detail")]
    public required string Detail { get; set; }
}