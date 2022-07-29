using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Standalone;

public class Account
{
    [JsonProperty("player_id")]
    public string PlayerId { get; set; }

    [JsonProperty("nickname")]
    public string Nickname { get; set; }

    [JsonProperty("avatar")]
    public string Avatar { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("cover_image")]
    public string CoverImage { get; set; }

    [JsonProperty("platforms")]
    public Dictionary<string, string> Platforms { get; set; }
    
    [JsonProperty("games")]
    public Dictionary<string, Game> Games { get; set; }
    
    [JsonProperty("settings")]
    public Settings Settings { get; set; }

    [JsonProperty("friends_ids")]
    public List<string> FriendsIds { get; set; }

    [JsonProperty("new_steam_id")]
    public string NewSteamId { get; set; }

    [JsonProperty("steam_id_64")]
    public string SteamId64 { get; set; }

    [JsonProperty("steam_nickname")]
    public string SteamNickname { get; set; }

    [JsonProperty("memberships")]
    public List<string> Memberships { get; set; }

    [JsonProperty("faceit_url")]
    public string FaceitUrl { get; set; }

    [JsonProperty("membership_type")]
    public string MembershipType { get; set; }

    [JsonProperty("cover_featured_image")]
    public string CoverFeaturedImage { get; set; }
    
    [JsonProperty("infractions")]
    public dynamic Infractions { get; set; }
}

public class Settings
{
    [JsonProperty("language")]
    public string Language { get; set; }
}