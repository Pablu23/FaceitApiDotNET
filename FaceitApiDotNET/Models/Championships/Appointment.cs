using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Championships;

public class Appointment
{
    [JsonProperty("date")]
    public int Date { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }
}