using FaceitApiDotNET.Models.PlayerInfo;
using FaceitApiDotNET.Models.Standalone;
using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.MatchDetails;

public class MatchDetailsTeam
{
    [JsonProperty("faction_id")]
    public string FactionId { get; set; }

    [JsonProperty("leader")]
    public string Leader { get; set; }

    [JsonProperty("avatar")]
    public string Avatar { get; set; }

    [JsonProperty("roster")]
    public List<Player> Players { get; set; }
    
    [JsonProperty("roster_v1")]
    public dynamic RosterV1 { get; set; }
    
    [JsonProperty("substituted")]
    public bool Substituted { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }
}