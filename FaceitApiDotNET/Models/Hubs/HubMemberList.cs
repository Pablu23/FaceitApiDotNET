using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Hubs;

public class HubMemberList
{
    [JsonProperty("end")]
    public int End { get; set; }

    [JsonProperty("items")]
    public List<HubMember> Items { get; set; }

    [JsonProperty("start")]
    public int Start { get; set; }
}