
namespace DotBox.Clients;

using System.Text.Json;
using System.Threading.Tasks;
using DotBox.Models.Torrent;

public class TorrentClient(string apiKey, HttpClient? httpClient = null)
    : BoxClient(apiKey, httpClient)
{
    /// <summary>
    /// Gets the user's torrent list. This gives you the needed information to perform other torrent actions. This information only gets updated every 600 seconds, or when the bypassCache parameter is set to true.
    /// </summary>
    /// <param name="offset">Determines the offset of items to get from the database. Default is 0. Optional.</param>
    /// <param name="limit">Determines the number of items to recieve per request. Default is 1000. Optional.</param>
    /// <param name="bypassCache">Allows you to bypass the cached data, and always get fresh information. Useful if constantly querying for fresh download stats. Otherwise, we request that you save our database a few calls.</param>
    /// <returns></returns>
    async Task<List<TorrentResponse>> GetTorrentListAsync(int offset, int limit, bool bypassCache = false)
    {
        var apiPath = $"/api/torrents/mylist?offset={offset}&limit={limit}";
        if (bypassCache)
        {
            apiPath += "&bypassCache=true";
        }

        var response = await httpClient.GetAsync(apiPath);
        response.EnsureSuccessStatusCode();

        var stringContent = await response.Content.ReadAsStringAsync();
        var content = JsonSerializer.Deserialize<List<TorrentResponse>>(stringContent);
        if (content is not null && content.Count > 0)
        {
            return content;
        }
        return [];
    }

    /// <summary>
    /// Gets the user's torrent specified by the passed id parameter. This gives you the needed information to perform other torrent actions. This information only gets updated every 600 seconds, or when the bypassCache parameter is set to true.
    /// </summary>
    /// <param name="id">Determines the torrent requested, will return an object rather than list.</param>
    /// <param name="bypassCache">Allows you to bypass the cached data, and always get fresh information. Useful if constantly querying for fresh download stats. Otherwise, we request that you save our database a few calls.</param>
    /// <returns></returns>
    TorrentResponse GetTorrentAsync(int id, bool bypassCache = false)
    {
        
    }
}