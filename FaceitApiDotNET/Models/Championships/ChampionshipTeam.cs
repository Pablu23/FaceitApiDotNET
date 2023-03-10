using FaceitApiDotNET.Models.Standalone;
using Newtonsoft.Json;
using FaceitApiDotNET.Models.PlayerInfo;

namespace FaceitApiDotNET.Models.Championships;

public class ChampionshipTeam
{
    [JsonProperty("avatar")]
    public string Avatar { get; set; }

    [JsonProperty("chat_room_id")]
    public string ChatRoomId { get; set; }

    [JsonProperty("cover_image")]
    public string CoverImage { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("facebook")]
    public string Facebook { get; set; }

    [JsonProperty("faceit_url")]
    public string FaceitUrl { get; set; }

    [JsonProperty("game")]
    public string Game { get; set; }

    [JsonProperty("leader")]
    public string Leader { get; set; }

    // [JsonProperty("members")]
    // public List<ChampionshipPlayer> Members { get; set; }

    [JsonProperty("members")]
    public List<Player> Members { get; set; }
    
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("nickname")]
    public string Nickname { get; set; }

    [JsonProperty("team_id")]
    public string TeamId { get; set; }

    [JsonProperty("team_type")]
    public string TeamType { get; set; }

    [JsonProperty("twitter")]
    public string Twitter { get; set; }

    [JsonProperty("website")]
    public string Website { get; set; }

    [JsonProperty("youtube")]
    public string Youtube { get; set; }
}