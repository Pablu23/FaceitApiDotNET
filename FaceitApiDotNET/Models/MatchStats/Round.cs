using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.MatchStats;

public class Round
{
    [JsonProperty("best_of")]
    public string BestOf { get; set; }

    [JsonProperty("competition_id")]
    public string CompetitionId { get; set; }

    [JsonProperty("game_id")]
    public string GameId { get; set; }

    [JsonProperty("game_mode")]
    public string GameMode { get; set; }

    [JsonProperty("match_id")]
    public string MatchId { get; set; }

    [JsonProperty("match_round")]
    public string MatchRound { get; set; }

    [JsonProperty("played")]
    public string Played { get; set; }

    [JsonProperty("round_stats")]
    public RoundStats RoundStats { get; set; }

    [JsonProperty("teams")]
    public List<MatchStatsTeam> Teams { get; set; }
}