using System.ComponentModel;
using System.Text.Json.Serialization;

namespace DotBox.Models.User;

public class UserResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("auth_id")]
    public required string AuthId { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [JsonPropertyName("plan")]
    public Plan Plan { get; set; }

    [JsonPropertyName("total_downloaded")]
    public int TotalDownloaded { get; set; }

    [JsonPropertyName("customer")]
    public required string Customer { get; set; }

    [JsonPropertyName("is_subscribed")]
    public bool IsSubscribed { get; set; }

    [JsonPropertyName("premium_expires_at")]
    public DateTime? PremiumExpiresAt { get; set; }

    [JsonPropertyName("cooldown_until")]
    public DateTime? CooldownUntil { get; set; }

    [JsonPropertyName("email")]
    public required string Email { get; set; }

    [JsonPropertyName("user_referral")]
    public required string UserReferral { get; set; }

    [JsonPropertyName("base_email")]
    public required string BaseEmail { get; set; }

    [JsonPropertyName("total_bytes_downloaded")]
    public long TotalBytesDownloaded { get; set; }

    [JsonPropertyName("total_bytes_uploaded")]
    public long TotalBytesUploaded { get; set; }

    [JsonPropertyName("torrents_downloaded")]
    public int TorrentsDownloaded { get; set; }

    [JsonPropertyName("web_downloads_downloaded")]
    public int WebDownloadsDownloaded { get; set; }

    [JsonPropertyName("usenet_downloads_downloaded")]
    public int UsenetDownloadsDownloaded { get; set; }

    [JsonPropertyName("additional_concurrent_slots")]
    public int AdditionalConcurrentSlots { get; set; }

    [JsonPropertyName("long_term_seeding")]
    public bool LongTermSeeding { get; set; }

    [JsonPropertyName("long_term_storage")]
    public bool LongTermStorage { get; set; }

    [JsonPropertyName("is_vendor")]
    public bool IsVendor { get; set; }

    [JsonPropertyName("vendor_id")]
    public string? VendorId { get; set; }

    [JsonPropertyName("purchases_referred")]
    public int PurchasesReferred { get; set; }

    [JsonPropertyName("settings")]
    public Settings Settings { get; set; }
}

public class Settings
{
    [JsonPropertyName("email_notifications")]
    public bool EmailNotifications { get; set; }

    [JsonPropertyName("web_notifications")]
    public bool WebNotifications { get; set; }

    [JsonPropertyName("mobile_notifications")]
    public bool MobileNotifications { get; set; }

    [JsonPropertyName("rss_notifications")]
    public bool RssNotifications { get; set; }

    [JsonPropertyName("download_speed_in_tab")]
    public bool DownloadSpeedInTab { get; set; }

    [JsonPropertyName("show_tracker_in_torrent")]
    public bool ShowTrackerInTorrent { get; set; }

    [JsonPropertyName("stremio_quality")]
    public IEnumerable<StremioQuality> StremioQuality { get; set; } = [];

    [JsonPropertyName("stremio_resolution")]
    public IEnumerable<StremioResolution> StremioResolution { get; set; } = [];

    [JsonPropertyName("stremio_language")]
    public IEnumerable<StremioLanguage> StremioLanguage { get; set; } = [];

    [JsonPropertyName("stremio_cache")]
    public IEnumerable<StremioCache> StremioCache { get; set; } = [];

    [JsonPropertyName("stremio_size_lower")]
    public int StremioSizeLower { get; set; }

    [JsonPropertyName("google_drive_folder_id")]
    public required string GoogleDriveFolderId { get; set; }

    [JsonPropertyName("onedrive_save_path")]
    public required string OnedriveSavePath { get; set; }

    [JsonPropertyName("discord_id")]
    public required string DiscordId { get; set; }

    [JsonPropertyName("discord_notifications")]
    public bool DiscordNotifications { get; set; }

    [JsonPropertyName("stremio_allow_adult")]
    public bool StremioAllowAdult { get; set; }

    [JsonPropertyName("stremio_seed_torrents")]
    public int StremioSeedTorrents { get; set; }

    [JsonPropertyName("seed_torrents")]
    public int SeedTorrents { get; set; }

    [JsonPropertyName("allow_zipped")]
    public bool AllowZipped { get; set; }

    [JsonPropertyName("stremio_allow_zipped")]
    public bool StremioAllowZipped { get; set; }

    [JsonPropertyName("onefichier_folder_id")]
    public string? OnefichierFolderId { get; set; }

    [JsonPropertyName("gofile_folder_id")]
    public string? GofileFolderId { get; set; }

    [JsonPropertyName("jdwonloader_notifications")]
    public bool JdownloaderNotifications { get; set; }
}