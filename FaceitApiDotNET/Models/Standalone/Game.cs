using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Standalone;

public class Game
{
    [JsonProperty("region")]
    public string Region { get; set; }

    [JsonProperty("game_player_id")]
    public string GamePlayerId { get; set; }

    [JsonProperty("skill_level")]
    public int SkillLevel { get; set; }

    [JsonProperty("faceit_elo")]
    public int FaceitElo { get; set; }

    [JsonProperty("game_player_name")]
    public string GamePlayerName { get; set; }

    [JsonProperty("skill_level_label")]
    public string SkillLevelLabel { get; set; }

    [JsonProperty("regions")]
    public dynamic Regions { get; set; }

    [JsonProperty("game_profile_id")]
    public string GameProfileId { get; set; }
}