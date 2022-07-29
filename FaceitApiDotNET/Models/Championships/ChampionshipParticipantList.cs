using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Championships;

public class ChampionshipParticipantList
{
    [JsonProperty("end")]
    public int End { get; set; }

    [JsonProperty("items")]
    public List<ChampionshipParticipant> Items { get; set; }

    [JsonProperty("start")]
    public int Start { get; set; }
}