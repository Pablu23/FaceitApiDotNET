using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Championships;

public class JoinChecks
{
    [JsonProperty("allowed_team_types")]
    public List<string> AllowedTeamTypes { get; set; }

    [JsonProperty("blacklist_geo_countries")]
    public List<string> BlacklistGeoCountries { get; set; }

    [JsonProperty("join_policy")]
    public string JoinPolicy { get; set; }

    [JsonProperty("max_skill_level")]
    public int MaxSkillLevel { get; set; }

    [JsonProperty("membership_type")]
    public string MembershipType { get; set; }

    [JsonProperty("min_skill_level")]
    public int MinSkillLevel { get; set; }

    [JsonProperty("whitelist_geo_countries")]
    public List<string> WhitelistGeoCountries { get; set; }

    [JsonProperty("whitelist_geo_countries_min_players")]
    public int WhitelistGeoCountriesMinPlayers { get; set; }
}