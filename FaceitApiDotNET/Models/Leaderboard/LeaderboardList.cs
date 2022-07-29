using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Leaderboard;

public class LeaderboardList
{
    [JsonProperty("end")]
    public int End { get; set; }

    [JsonProperty("items")]
    public List<Leaderboard> Items { get; set; }

    [JsonProperty("start")]
    public int Start { get; set; }
}