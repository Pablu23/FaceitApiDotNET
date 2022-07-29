using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Championships;

public class Prize
{
    [JsonProperty("faceit_points")]
    public int FaceitPoints { get; set; }

    [JsonProperty("rank")]
    public int Rank { get; set; }
}