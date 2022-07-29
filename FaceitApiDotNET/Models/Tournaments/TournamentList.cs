using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Tournaments;

public class TournamentList
{
    [JsonProperty("end")]
    public int End { get; set; }

    [JsonProperty("items")]
    public List<Tournament> Items { get; set; }

    [JsonProperty("start")]
    public int Start { get; set; }
}