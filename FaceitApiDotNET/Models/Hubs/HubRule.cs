using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Hubs;

public class HubRule
{
    [JsonProperty("body")]
    public string Body { get; set; }

    [JsonProperty("game")]
    public string Game { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("organizer")]
    public string Organizer { get; set; }

    [JsonProperty("rule_id")]
    public string RuleId { get; set; }
}