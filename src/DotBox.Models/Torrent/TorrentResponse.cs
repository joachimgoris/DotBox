using System.Text.Json.Serialization;

namespace DotBox.Models.Torrent;

public class TorrentResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("auth_id")]
    public string AuthId { get; set; }
    
    [JsonPropertyName("server")]
    public int Server { get; set; }
    
    [JsonPropertyName("hash")]
    public string Hash { get; set; }
    
    [JsonPropertyName("name")]
    public required string Name { get; set; }
    
    [JsonPropertyName("magnet")]
    public string? Magnet { get; set; }
    
    [JsonPropertyName("size")]
    public long Size { get; set; }
    
    [JsonPropertyName("active")]
    public bool Active { get; set; }
    
    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }
    
    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }
    
    [JsonPropertyName("download_state")]
    public required string DownloadState { get; set; }
    
    [JsonPropertyName("seeds")]
    public int Seeds { get; set; }
    
    [JsonPropertyName("peers")]
    public int Peers { get; set; }
    
    [JsonPropertyName("ratio")]
    public double Ratio { get; set; }
    
    [JsonPropertyName("progress")]
    public bool Progress { get; set; }
    
    [JsonPropertyName("download_speed")]
    public long DownloadSpeed { get; set; }
    
    [JsonPropertyName("upload_speed")]
    public long UploadSpeed { get; set; }
    
    [JsonPropertyName("eta")]
    public int Eta { get; set; }
    
    [JsonPropertyName("torrent_file")]
    public bool TorrentFile { get; set; }
    
    [JsonPropertyName("expires_at")]
    public DateTimeOffset ExpiresAt { get; set; }
    
    [JsonPropertyName("download_present")]
    public bool DownloadPresent { get; set; }
    
    [JsonPropertyName("files")]
    public IEnumerable<FileResponse> Files { get; set; }
}