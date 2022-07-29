using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Hubs;

public class HubMember
{
    [JsonProperty("avatar")]
    public string Avatar { get; set; }

    [JsonProperty("faceit_url")]
    public string FaceitUrl { get; set; }

    [JsonProperty("nickname")]
    public string Nickname { get; set; }

    [JsonProperty("roles")]
    public List<string> Roles { get; set; }

    [JsonProperty("user_id")]
    public string UserId { get; set; }
}