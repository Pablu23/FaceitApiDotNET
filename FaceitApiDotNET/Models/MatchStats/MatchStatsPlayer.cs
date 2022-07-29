using FaceitApiDotNET.Models.PlayerInfo;
using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.MatchStats;

public class MatchStatsPlayer
{
    [JsonProperty("player_id")]
    public string PlayerId { get; set; }

    [JsonProperty("nickname")]
    public string Nickname { get; set; }

    [JsonProperty("player_stats")]
    public PlayerStats PlayerStats { get; set; }
}