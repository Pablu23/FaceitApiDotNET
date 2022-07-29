using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.PlayerInfo;

public class Player
{
    [JsonProperty("player_id")]
    public string PlayerId { get; set; }
    
    [JsonProperty("game_player_id")]
    public string GamePlayerId { get; set; }
    
    [JsonProperty("game_player_name")]
    public string GamePlayerName { get; set; }
    
    [JsonProperty("game_skill_level")]
    public int GameSkillLevel { get; set; }
    
    [JsonProperty("avatar")]
    public string Avatar { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("faceit_url")]
    public string FaceitUrl { get; set; }

    [JsonProperty("membership_type")]
    public string MembershipType { get; set; }

    [JsonProperty("memberships")]
    public List<string> Memberships { get; set; }

    [JsonProperty("nickname")]
    public string Nickname { get; set; }
    
    [JsonProperty("skill_level")]
    public int SkillLevel { get; set; }

    [JsonProperty("user_id")]
    public string UserId { get; set; }
    
    [JsonProperty("anticheat_required")]
    public bool AnticheatRequired { get; set; }
    
    [JsonProperty("player_stats")]
    public PlayerStats PlayerStats { get; set; }
}