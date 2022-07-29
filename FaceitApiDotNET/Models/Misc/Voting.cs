using FaceitApiDotNET.Models.MatchDetails;
using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Misc;

public class Voting
{
    [JsonProperty("map")]
    public MapInfo Map { get; set; }

    [JsonProperty("voted_entity_types")]
    public List<string> VotedEntityTypes { get; set; }

    [JsonProperty("location")]
    public LocationInfo Location { get; set; }
}

public class LocationInfo
{
    [JsonProperty("entities")]
    public List<VotingEntity> BannedLocations { get; set; }

    [JsonProperty("pick")]
    public List<string> Pick { get; set; }
}

public class MapInfo
{
    [JsonProperty("entities")]
    public List<VotingEntity> BannedMaps { get; set; }

    [JsonProperty("pick")]
    public List<string> Pick { get; set; }
}