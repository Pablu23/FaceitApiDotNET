using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Leaderboard;

public class GroupRankingList
{
    [JsonProperty("end")]
    public int End { get; set; }

    [JsonProperty("items")]
    public List<LeaderboardEntry> Items { get; set; }

    [JsonProperty("leaderboard")]
    public Leaderboard Leaderboard { get; set; }

    [JsonProperty("start")]
    public int Start { get; set; }
}