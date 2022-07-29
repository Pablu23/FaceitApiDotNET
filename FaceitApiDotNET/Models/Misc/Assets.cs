using Newtonsoft.Json;

namespace FaceitApiDotNET.Models.Misc;

public class Assets
{
    [JsonProperty("cover")]
    public string Cover { get; set; }

    [JsonProperty("flag_img_icon")]
    public string FlagImgIcon { get; set; }

    [JsonProperty("flag_img_s")]
    public string FlagImgS { get; set; }

    [JsonProperty("flag_img_m")]
    public string FlagImgM { get; set; }

    [JsonProperty("flag_img_l")]
    public string FlagImgL { get; set; }

    [JsonProperty("featured_img_s")]
    public string FeaturedImgS { get; set; }

    [JsonProperty("featured_img_m")]
    public string FeaturedImgM { get; set; }

    [JsonProperty("featured_img_l")]
    public string FeaturedImgL { get; set; }

    [JsonProperty("landing_page")]
    public string LandingPage { get; set; }
}