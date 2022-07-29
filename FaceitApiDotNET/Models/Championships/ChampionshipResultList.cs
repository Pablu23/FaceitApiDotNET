using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Championships;

public class ChampionshipResultList
{
    [JsonProperty("end")]
    public int End { get; set; }

    [JsonProperty("items")]
    public List<ChampionshipResult> Items { get; set; }

    [JsonProperty("start")]
    public int Start { get; set; }
}