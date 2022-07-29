using FaceitApiDotNET.Models.Hubs;
using FaceitApiDotNET.Models.Misc;
using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Championships;

public class Championship
{
    [JsonProperty("anticheat_required")] 
    public bool AnticheatRequired { get; set; }

    [JsonProperty("avatar")] 
    public string Avatar { get; set; }

    [JsonProperty("background_image")] 
    public string BackgroundImage { get; set; }

    [JsonProperty("championship_id")] 
    public string ChampionshipId { get; set; }

    [JsonProperty("championship_start")] 
    public int ChampionshipStart { get; set; }

    [JsonProperty("checkin_clear")] 
    public int CheckinClear { get; set; }

    [JsonProperty("checkin_enabled")] 
    public bool CheckinEnabled { get; set; }

    [JsonProperty("checkin_start")] 
    public int CheckinStart { get; set; }

    [JsonProperty("cover_image")] 
    public string CoverImage { get; set; }

    [JsonProperty("current_subscriptions")]
    public int CurrentSubscriptions { get; set; }

    [JsonProperty("description")] 
    public string Description { get; set; }

    [JsonProperty("faceit_url")] 
    public string FaceitUrl { get; set; }

    [JsonProperty("featured")] 
    public bool Featured { get; set; }

    [JsonProperty("full")] 
    public bool Full { get; set; }

    [JsonProperty("game_data")] 
    public GameDetails.GameDetails GameData { get; set; }

    [JsonProperty("game_id")] 
    public string GameId { get; set; }

    [JsonProperty("id")] 
    public string Id { get; set; }

    [JsonProperty("join_checks")] 
    public JoinChecks JoinChecks { get; set; }

    [JsonProperty("name")] 
    public string Name { get; set; }

    [JsonProperty("organizer_data")] 
    public OrganizerData OrganizerData { get; set; }

    [JsonProperty("organizer_id")] 
    public string OrganizerId { get; set; }

    [JsonProperty("prizes")] 
    public List<Prize> Prizes { get; set; }

    [JsonProperty("region")] 
    public string Region { get; set; }

    [JsonProperty("rules_id")] 
    public string RulesId { get; set; }

    [JsonProperty("schedule")] 
    public Dictionary<string, Appointment> Schedule { get; set; }

    [JsonProperty("seeding_strategy")] 
    public string SeedingStrategy { get; set; }

    [JsonProperty("slots")] 
    public int Slots { get; set; }

    [JsonProperty("status")] 
    public string Status { get; set; }

    [JsonProperty("stream")] 
    public Stream Stream { get; set; }

    [JsonProperty("subscription_end")] 
    public int SubscriptionEnd { get; set; }

    [JsonProperty("subscription_start")] 
    public int SubscriptionStart { get; set; }

    [JsonProperty("subscriptions_locked")] 
    public bool SubscriptionsLocked { get; set; }

    [JsonProperty("substitution_configuration")]
    public SubstitutionConfiguration SubstitutionConfiguration { get; set; }

    [JsonProperty("total_groups")] 
    public int TotalGroups { get; set; }

    [JsonProperty("total_prizes")] 
    public int TotalPrizes { get; set; }

    [JsonProperty("total_rounds")] 
    public int TotalRounds { get; set; }

    [JsonProperty("type")] 
    public string Type { get; set; }
}