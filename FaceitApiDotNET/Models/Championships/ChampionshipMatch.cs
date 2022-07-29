using FaceitApiDotNET.Models.MatchDetails;
using FaceitApiDotNET.Models.Misc;
using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Championships;

public class ChampionshipMatch
{
    [JsonProperty("best_of")]
    public int BestOf { get; set; }

    [JsonProperty("broadcast_start_time")]
    public int BroadcastStartTime { get; set; }

    [JsonProperty("broadcast_start_time_label")]
    public string BroadcastStartTimeLabel { get; set; }

    [JsonProperty("calculate_elo")]
    public bool CalculateElo { get; set; }

    [JsonProperty("chat_room_id")]
    public string ChatRoomId { get; set; }

    [JsonProperty("competition_id")]
    public string CompetitionId { get; set; }

    [JsonProperty("competition_name")]
    public string CompetitionName { get; set; }

    [JsonProperty("competition_type")]
    public string CompetitionType { get; set; }

    [JsonProperty("configured_at")]
    public int ConfiguredAt { get; set; }

    [JsonProperty("demo_url")]
    public List<string> DemoUrl { get; set; }

    [JsonProperty("faceit_url")]
    public string FaceitUrl { get; set; }

    [JsonProperty("finished_at")]
    public int FinishedAt { get; set; }

    [JsonProperty("game")]
    public string Game { get; set; }

    [JsonProperty("group")]
    public int Group { get; set; }

    [JsonProperty("match_id")]
    public string MatchId { get; set; }

    [JsonProperty("organizer_id")]
    public string OrganizerId { get; set; }

    [JsonProperty("region")]
    public string Region { get; set; }

    [JsonProperty("results")]
    public Results Results { get; set; }

    [JsonProperty("round")]
    public int Round { get; set; }

    [JsonProperty("scheduled_at")]
    public int ScheduledAt { get; set; }

    [JsonProperty("started_at")]
    public int StartedAt { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("teams")]
    public Dictionary<string, MatchDetailsTeam> Teams { get; set; }

    [JsonProperty("version")]
    public int Version { get; set; }

    [JsonProperty("voting")]
    public Voting Voting { get; set; }
}