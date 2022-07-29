using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.MatchStats;

public class MatchPlayerStats
{
    [JsonProperty("Deaths")]
    public string Deaths { get; set; }

    [JsonProperty("Headshots %")]
    public string HeadshotsPercentage { get; set; }

    [JsonProperty("Quadro Kills")]
    public string QuadroKills { get; set; }

    [JsonProperty("K/D Ratio")]
    public string KDRatio { get; set; }

    [JsonProperty("Headshots")]
    public string Headshots { get; set; }

    [JsonProperty("Penta Kills")]
    public string PentaKills { get; set; }

    [JsonProperty("Triple Kills")]
    public string TripleKills { get; set; }

    [JsonProperty("MVPs")]
    public string MVPs { get; set; }

    [JsonProperty("Assists")]
    public string Assists { get; set; }

    [JsonProperty("K/R Ratio")]
    public string KRRatio { get; set; }

    [JsonProperty("Result")]
    public string Result { get; set; }

    [JsonProperty("Kills")]
    public string Kills { get; set; }
}