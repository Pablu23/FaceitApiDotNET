using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Championships;

public class Bounds
{
    [JsonProperty("left")]
    public int Left { get; set; }

    [JsonProperty("right")]
    public int Right { get; set; }
}