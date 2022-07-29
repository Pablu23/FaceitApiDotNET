using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Hubs;

public class HubRoleList
{
    [JsonProperty("end")]
    public int End { get; set; }

    [JsonProperty("items")]
    public List<HubRole> Items { get; set; }

    [JsonProperty("start")]
    public int Start { get; set; }
}