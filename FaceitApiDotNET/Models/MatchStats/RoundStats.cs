using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.MatchStats;

public class RoundStats
{
    [JsonProperty("Map")]
    public string Map { get; set; }

    [JsonProperty("Region")]
    public string Region { get; set; }

    [JsonProperty("Rounds")]
    public string Rounds { get; set; }

    [JsonProperty("Score")]
    public string Score { get; set; }

    [JsonProperty("Winner")]
    public string Winner { get; set; }
}