using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Championships;

public class SubstitutionConfiguration
{
    [JsonProperty("max_substitutes")]
    public int MaxSubstitutes { get; set; }

    [JsonProperty("max_substitutions")]
    public int MaxSubstitutions { get; set; }
}