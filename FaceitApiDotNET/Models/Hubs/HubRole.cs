using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Hubs;

public class HubRole
{
    [JsonProperty("color")]
    public string Color { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("ranking")]
    public int Ranking { get; set; }

    [JsonProperty("role_id")]
    public string RoleId { get; set; }

    [JsonProperty("visible_on_chat")]
    public bool VisibleOnChat { get; set; }
}