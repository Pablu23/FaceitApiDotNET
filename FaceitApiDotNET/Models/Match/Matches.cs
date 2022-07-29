using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Match;

public class MatchList
{
    [JsonProperty("items")]
    public List<Match> Matches { get; set; }

    [JsonProperty("start")]
    public int Start { get; set; }

    [JsonProperty("end")]
    public int End { get; set; }

    [JsonProperty("from")]
    public int From { get; set; }

    [JsonProperty("to")]
    public int To { get; set; }
}