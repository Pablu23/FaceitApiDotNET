﻿using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Misc;

public class MatchResults
{
    [JsonProperty("winner")]
    public string Winner { get; set; }

    [JsonProperty("score")]
    public Dictionary<string, int> Score { get; set; }
}