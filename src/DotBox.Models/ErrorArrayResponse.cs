using System.Text.Json.Serialization;

namespace DotBox.Models;

public class ErrorArrayResponse
{
    [JsonPropertyName("detail")]
    public IEnumerable<ErrorDetail> Detail { get; set; } = [];
}
