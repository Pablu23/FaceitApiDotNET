using FaceitApiDotNET.Models.PlayerInfo;
using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.MatchStats;

public class MatchStatsTeam
{
    [JsonProperty("team_id")]
    public string TeamId { get; set; }

    [JsonProperty("premade")]
    public bool Premade { get; set; }

    [JsonProperty("team_stats")]
    public TeamStats TeamStats { get; set; }

    [JsonProperty("players")]
    public List<Player> Players { get; set; }
}