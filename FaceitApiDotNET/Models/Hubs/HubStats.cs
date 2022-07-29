using FaceitApiDotNET.Models.MatchStats;
using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Hubs;

public class HubStats
{
    [JsonProperty("game_id")]
    public string GameId { get; set; }

    [JsonProperty("players")]
    public List<PlayerStats> Players { get; set; }
}