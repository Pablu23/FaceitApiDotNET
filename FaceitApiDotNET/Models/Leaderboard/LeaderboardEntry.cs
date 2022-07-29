using FaceitApiDotNET.Models.Championships;
using FaceitApiDotNET.Models.PlayerInfo;
using FaceitApiDotNET.Models.Standalone;
using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Leaderboard;

public class LeaderboardEntry
{
    [JsonProperty("current_streak")]
    public int CurrentStreak { get; set; }

    [JsonProperty("draw")]
    public int Draw { get; set; }

    [JsonProperty("lost")]
    public int Lost { get; set; }

    [JsonProperty("played")]
    public int Played { get; set; }

    [JsonProperty("player")]
    public Player Player { get; set; }

    [JsonProperty("points")]
    public int Points { get; set; }

    [JsonProperty("position")]
    public int Position { get; set; }

    [JsonProperty("win_rate")]
    public int WinRate { get; set; }

    [JsonProperty("won")]
    public int Won { get; set; }
}