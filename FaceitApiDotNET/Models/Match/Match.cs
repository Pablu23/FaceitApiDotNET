using FaceitApiDotNET.Models.Misc;
using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Match;


public class Match
{
    [JsonProperty("match_id")]
    public string MatchId { get; set; }

    [JsonProperty("game_id")]
    public string GameId { get; set; }

    [JsonProperty("region")]
    public string Region { get; set; }

    [JsonProperty("match_type")]
    public string MatchType { get; set; }

    [JsonProperty("game_mode")]
    public string GameMode { get; set; }

    [JsonProperty("max_players")]
    public int MaxPlayers { get; set; }

    [JsonProperty("teams_size")]
    public int TeamsSize { get; set; }

    [JsonProperty("teams")]
    public Dictionary<string, MatchTeam> Teams { get; set; }

    [JsonProperty("playing_players")]
    public List<string> PlayingPlayers { get; set; }

    [JsonProperty("competition_id")]
    public string CompetitionId { get; set; }

    [JsonProperty("competition_name")]
    public string CompetitionName { get; set; }

    [JsonProperty("competition_type")]
    public string CompetitionType { get; set; }

    [JsonProperty("organizer_id")]
    public string OrganizerId { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("started_at")]
    public int StartedAt { get; set; }

    [JsonProperty("finished_at")]
    public int FinishedAt { get; set; }

    [JsonProperty("results")]
    public Results Results { get; set; }

    [JsonProperty("faceit_url")]
    public string FaceitUrl { get; set; }
}