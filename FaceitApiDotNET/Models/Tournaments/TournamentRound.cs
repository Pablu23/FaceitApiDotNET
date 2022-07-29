using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Tournaments;

public class TournamentRound
{
    [JsonProperty("best_of")]
    public int BestOf { get; set; }

    [JsonProperty("label")]
    public string Label { get; set; }

    [JsonProperty("matches")]
    public int Matches { get; set; }

    [JsonProperty("round")]
    public int Round { get; set; }

    [JsonProperty("start_time")]
    public int StartTime { get; set; }

    [JsonProperty("starts_asap")]
    public bool StartsAsap { get; set; }

    [JsonProperty("substitution_time")]
    public int SubstitutionTime { get; set; }

    [JsonProperty("substitutions_allowed")]
    public bool SubstitutionsAllowed { get; set; }
}