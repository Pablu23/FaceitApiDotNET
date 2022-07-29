using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.MatchStats;

public class MatchStats
{
    [JsonProperty("rounds")]
    public List<Round> Rounds { get; set; }
}