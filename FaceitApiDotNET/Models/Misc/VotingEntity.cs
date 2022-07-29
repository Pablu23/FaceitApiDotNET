using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Misc;

public class VotingEntity
{
    [JsonProperty("guid")] 
    public string Guid { get; set; }

    [JsonProperty("image_lg")] 
    public string ImageLg { get; set; }

    [JsonProperty("image_sm")] 
    public string ImageSm { get; set; }

    [JsonProperty("name")] 
    public string Name { get; set; }

    [JsonProperty("class_name")] 
    public string ClassName { get; set; }

    [JsonProperty("game_map_id")] 
    public string GameMapId { get; set; }

    [JsonProperty("game_location_id")] 
    public string GameLocationId { get; set; }
}