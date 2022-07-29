using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Championships;

public class ChampionshipParticipant
{
    [JsonProperty("coach")]
    public string Coach { get; set; }

    [JsonProperty("coleader")]
    public string Coleader { get; set; }

    [JsonProperty("group")]
    public int Group { get; set; }

    [JsonProperty("leader")]
    public string Leader { get; set; }

    [JsonProperty("roster")]
    public List<string> Roster { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("substitutes")]
    public List<string> Substitutes { get; set; }

    [JsonProperty("team")]
    public ChampionshipTeam Team { get; set; }
}