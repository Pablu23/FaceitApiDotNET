using FaceitApiDotNET.Models.Championships;
using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Misc;

public class InformationList<T>
{
    [JsonProperty("end")]
    public int End { get; set; }

    [JsonProperty("items")]
    public List<T> Items { get; set; }

    [JsonProperty("start")]
    public int Start { get; set; }
    
    [JsonProperty("from")]
    public int From { get; set; }

    [JsonProperty("to")]
    public int To { get; set; }
}