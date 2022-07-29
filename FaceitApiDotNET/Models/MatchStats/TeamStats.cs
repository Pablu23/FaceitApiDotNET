using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.MatchStats;

public class TeamStats
{
    [JsonProperty("Team Win")]
    public string TeamWin { get; set; }

    [JsonProperty("Team Headshots")]
    public string TeamHeadshots { get; set; }

    [JsonProperty("Final Score")]
    public string FinalScore { get; set; }

    [JsonProperty("First Half Score")]
    public string FirstHalfScore { get; set; }

    [JsonProperty("Second Half Score")]
    public string SecondHalfScore { get; set; }

    [JsonProperty("Team")]
    public string Team { get; set; }

    [JsonProperty("Overtime score")]
    public string OvertimeScore { get; set; }
}