using System.Text.Json.Serialization;

namespace DotBox.Models.User;

public class DashboardFilter
{
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    [JsonPropertyName("cached")]
    public bool Cached { get; set; }

    [JsonPropertyName("inactive")]
    public bool Inactive { get; set; }

    [JsonPropertyName("torrents")]
    public bool Torrents { get; set; }

    [JsonPropertyName("uploading")]
    public bool Uploading { get; set; }

    [JsonPropertyName("donwloading")]
    public bool Downloading { get; set; }

    [JsonPropertyName("web_downloads")]
    public bool WebDownloads { get; set; }

    [JsonPropertyName("download_ready")]
    public bool DownloadReady { get; set; }

    [JsonPropertyName("usenet_downloads")]
    public bool UsenetDownloads { get; set; }
}