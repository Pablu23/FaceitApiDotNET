using FaceitApiDotNET.Models.Match;
using FaceitApiDotNET.Models.Misc;
using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Tournaments;

public class TournamentMatch
{
    [JsonProperty("faceit_url")]
    public string FaceitUrl { get; set; }

    [JsonProperty("match_id")]
    public string MatchId { get; set; }

    [JsonProperty("position")]
    public int Position { get; set; }

    [JsonProperty("results")]
    public Results Results { get; set; }

    [JsonProperty("round")]
    public int Round { get; set; }

    [JsonProperty("state")]
    public string State { get; set; }

    [JsonProperty("teams")]
    public Dictionary<string, MatchTeam> Teams { get; set; }
}