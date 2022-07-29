using FaceitApiDotNET.Models.Misc;
using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.GameDetails;

public class GameDetails
{
    [JsonProperty("game_id")]
    public string GameId { get; set; }

    [JsonProperty("short_label")]
    public string ShortLabel { get; set; }

    [JsonProperty("long_label")]
    public string LongLabel { get; set; }

    [JsonProperty("assets")]
    public Assets Assets { get; set; }

    [JsonProperty("platforms")]
    public List<string> Platforms { get; set; }

    [JsonProperty("regions")]
    public List<string> Regions { get; set; }

    [JsonProperty("parent_game_id")]
    public string ParentGameId { get; set; }

    [JsonProperty("order")]
    public int Order { get; set; }
}