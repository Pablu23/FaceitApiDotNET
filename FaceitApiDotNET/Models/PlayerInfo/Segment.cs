using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.PlayerInfo;

public class Segment
{
    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("mode")]
    public string Mode { get; set; }

    [JsonProperty("label")]
    public string Label { get; set; }

    [JsonProperty("img_small")]
    public string ImgSmall { get; set; }

    [JsonProperty("img_regular")]
    public string ImgRegular { get; set; }

    [JsonProperty("stats")]
    public PlayerStats Stats { get; set; }
}