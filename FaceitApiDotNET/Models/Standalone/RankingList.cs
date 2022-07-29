using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Standalone;

public class RankingList
{
    [JsonProperty("end")]
    public int End { get; set; }

    [JsonProperty("items")]
    public List<Ranking> Items { get; set; }

    [JsonProperty("position")]
    public int Position { get; set; }

    [JsonProperty("start")]
    public int Start { get; set; }
}