using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Tournaments;

public class TournamentTeamList
{
    [JsonProperty("checked_in")]
    public List<TournamentTeam> CheckedIn { get; set; }
    
    [JsonProperty("finished")]
    public List<TournamentTeam> Finished { get; set; }
    
    [JsonProperty("joined")]
    public List<TournamentTeam> Joined { get; set; }
    
    [JsonProperty("started")]
    public List<TournamentTeam> Started { get; set; }
}