using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.GameDetails;

public class GameDetailsList
{
    [JsonProperty("items")]
    public List<GameDetails> Items { get; set; }

    [JsonProperty("start")]
    public int Start { get; set; }

    [JsonProperty("end")]
    public int End { get; set; }
}