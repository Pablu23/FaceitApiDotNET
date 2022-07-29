using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Championships;

public class Placement
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }
}