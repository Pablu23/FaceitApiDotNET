using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Championships;

public class Stream
{
    [JsonProperty("active")]
    public bool Active { get; set; }

    [JsonProperty("platform")]
    public string Platform { get; set; }

    [JsonProperty("source")]
    public string Source { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }
}