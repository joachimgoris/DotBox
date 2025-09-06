using System.Text.Json.Serialization;

namespace DotBox.Models;

public class HttpResponse<T>
    : HttpResponse
{
    [JsonPropertyName("data")]
    public T Data { get; set; }
}