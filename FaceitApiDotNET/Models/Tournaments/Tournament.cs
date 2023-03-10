using System.Reflection.Emit;
using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Tournaments;

public class Tournament
{
    [JsonProperty("anticheat_required")]
    public bool AnticheatRequired { get; set; }

    [JsonProperty("custom")]
    public bool Custom { get; set; }

    [JsonProperty("faceit_url")]
    public string FaceitUrl { get; set; }

    [JsonProperty("featured_image")]
    public string FeaturedImage { get; set; }

    [JsonProperty("game_id")]
    public string GameId { get; set; }

    [JsonProperty("invite_type")]
    public string InviteType { get; set; }

    [JsonProperty("match_type")]
    public string MatchType { get; set; }

    [JsonProperty("max_skill")]
    public int MaxSkill { get; set; }

    [JsonProperty("membership_type")]
    public string MembershipType { get; set; }

    [JsonProperty("min_skill")]
    public int MinSkill { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("number_of_players")]
    public int NumberOfPlayers { get; set; }

    [JsonProperty("number_of_players_checkedin")]
    public int NumberOfPlayersCheckedin { get; set; }

    [JsonProperty("number_of_players_joined")]
    public int NumberOfPlayersJoined { get; set; }

    [JsonProperty("number_of_players_participants")]
    public int NumberOfPlayersParticipants { get; set; }

    [JsonProperty("organizer_id")]
    public string OrganizerId { get; set; }

    [JsonProperty("prize_type")]
    public string PrizeType { get; set; }

    [JsonProperty("region")]
    public string Region { get; set; }

    [JsonProperty("started_at")]
    public int StartedAt { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("subscriptions_count")]
    public int SubscriptionsCount { get; set; }

    [JsonProperty("team_size")]
    public int TeamSize { get; set; }

    [JsonProperty("total_prize")]
    public dynamic TotalPrize { get; set; }

    [JsonProperty("tournament_id")]
    public string TournamentId { get; set; }

    [JsonProperty("whitelist_countries")]
    public List<string> WhitelistCountries { get; set; }
}