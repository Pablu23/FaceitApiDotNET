using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.PlayerInfo;

public class LifetimeStats
{
    [JsonProperty("player_id")]
    public string PlayerId { get; set; }

    [JsonProperty("game_id")]
    public string GameId { get; set; }

    [JsonProperty("lifetime")]
    public GeneralStats Lifetime { get; set; }

    [JsonProperty("segments")]
    public List<Segment> Segments { get; set; }  
}