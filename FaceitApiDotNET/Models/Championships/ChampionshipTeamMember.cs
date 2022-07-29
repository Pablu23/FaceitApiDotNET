﻿using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Championships;

public class ChampionshipTeamMember
{
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
}