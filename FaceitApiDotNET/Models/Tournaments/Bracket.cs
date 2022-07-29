using FaceitApiDotNET.Models.MatchStats;
using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Tournaments;

public class Bracket
{
    [JsonProperty("game")]
    public string Game { get; set; }

    [JsonProperty("matches")]
    public List<TournamentMatch> Matches { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("rounds")]
    public List<TournamentRound> Rounds { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }
}