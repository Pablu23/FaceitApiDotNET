using FaceitApiDotNET.Models.MatchStats;
using FaceitApiDotNET.Models.PlayerInfo;
using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Hubs;

public class HubStats
{
    [JsonProperty("game_id")]
    public string GameId { get; set; }

    [JsonProperty("players")]
    public List<Player> Players { get; set; }
}