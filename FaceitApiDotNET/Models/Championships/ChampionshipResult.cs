using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Championships;

public class ChampionshipResult
{
    [JsonProperty("bounds")]
    public Bounds Bounds { get; set; }

    [JsonProperty("placements")]
    public List<Placement> Placements { get; set; }
}