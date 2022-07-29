using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.MatchDetails;

public class MatchDetailsList
{
    [JsonProperty("end")]
    public int End { get; set; }

    [JsonProperty("items")]
    public List<MatchDetails> Items { get; set; }

    [JsonProperty("start")]
    public int Start { get; set; }
}