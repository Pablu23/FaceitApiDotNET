using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.PlayerInfo;

public class PlayerStats
{
    [JsonProperty("Quadro Kills")]
    public string QuadroKills { get; set; }

    [JsonProperty("Kills")]
    public string Kills { get; set; }

    [JsonProperty("Win Rate %")]
    public string WinRate { get; set; }

    [JsonProperty("Wins")]
    public string Wins { get; set; }

    [JsonProperty("MVPs")]
    public string MVPs { get; set; }

    [JsonProperty("Average MVPs")]
    public string AverageMVPs { get; set; }

    [JsonProperty("Average Quadro Kills")]
    public string AverageQuadroKills { get; set; }

    [JsonProperty("Average Penta Kills")]
    public string AveragePentaKills { get; set; }

    [JsonProperty("Deaths")]
    public string Deaths { get; set; }

    [JsonProperty("Assists")]
    public string Assists { get; set; }

    [JsonProperty("Total Headshots %")]
    public string TotalHeadshots { get; set; }

    [JsonProperty("Matches")]
    public string Matches { get; set; }

    [JsonProperty("Penta Kills")]
    public string PentaKills { get; set; }

    [JsonProperty("Average Deaths")]
    public string AverageDeaths { get; set; }

    [JsonProperty("K/R Ratio")]
    public string KRRatio { get; set; }

    [JsonProperty("Average Triple Kills")]
    public string AverageTripleKills { get; set; }

    [JsonProperty("Average K/R Ratio")]
    public string AverageKRRatio { get; set; }

    [JsonProperty("Rounds")]
    public string Rounds { get; set; }

    [JsonProperty("Headshots per Match")]
    public string HeadshotsPerMatch { get; set; }

    [JsonProperty("Average K/D Ratio")]
    public string AverageKDRatio { get; set; }

    [JsonProperty("Average Headshots %")]
    public string AverageHeadshots { get; set; }

    [JsonProperty("Headshots")]
    public string Headshots { get; set; }

    [JsonProperty("Triple Kills")]
    public string TripleKills { get; set; }

    [JsonProperty("K/D Ratio")]
    public string KDRatio { get; set; }

    [JsonProperty("Average Kills")]
    public string AverageKills { get; set; }

    [JsonProperty("Average Assists")]
    public string AverageAssists { get; set; }
}