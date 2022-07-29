using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Championships;

public class ChampionshipMatchList
{
    [JsonProperty("end")]
    public int End { get; set; }

    [JsonProperty("items")]
    public List<ChampionshipMatch> Items { get; set; }

    [JsonProperty("start")]
    public int Start { get; set; }
}