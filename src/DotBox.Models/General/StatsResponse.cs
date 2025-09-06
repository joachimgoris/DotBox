using System.Text.Json.Serialization;

namespace DotBox.Models.General;

public class StatsResponse
{
    [JsonPropertyName("total_downloads")]
    public int TotalDownloads { get; set; }

    [JsonPropertyName("total_users")]
    public int TotalUsers { get; set; }

    [JsonPropertyName("total_bytes_downloaded")]
    public long TotalBytesDownloaded { get; set; }

    [JsonPropertyName("total_bytes_uploaded")]
    public long TotalBytesUploaded { get; set; }

    [JsonPropertyName("total_bytes_egressed")]
    public long TotalBytesEgressed { get; set; }

    [JsonPropertyName("total_servers")]
    public int TotalServers { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }
}
