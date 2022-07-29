using System.Net.Http.Headers;
using FaceitApiDotNET.Models.Championships;
using FaceitApiDotNET.Models.Misc;
using Newtonsoft.Json;

namespace FaceitApiDotNET;

public class FaceitClient
{
    private HttpClient _client;

    public FaceitClient(string bearerToken)
    {
        _client = new HttpClient();
        _client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", bearerToken);
        _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public InformationList<Championship> GetChampionships(string game, string type = "all", int offset = 0,
        int limit = 20)
    {
        string url = Constants.GetChampionshipUrl(game, type, offset, limit);
        var response = _client.GetAsync(url).GetAwaiter().GetResult();

        if (response.IsSuccessStatusCode)
        {
            return JsonConvert.DeserializeObject<InformationList<Championship>>(response.Content.ReadAsStringAsync()
                .GetAwaiter().GetResult());
        }

        throw new Exception(response.StatusCode.ToString());
    }

    public Championship GetChampionshipDetails(string championshipId, params string[] expanded)
    {
        string url = Constants.GetChampionshipDetailsUrl(championshipId, expanded);
        var response = _client.GetAsync(url).GetAwaiter().GetResult();

        if (response.IsSuccessStatusCode)
        {
            return JsonConvert.DeserializeObject<Championship>(response.Content.ReadAsStringAsync().GetAwaiter()
                .GetResult());
        }

        throw new Exception(response.StatusCode.ToString());
    }

    public InformationList<ChampionshipMatch> GetChampionshipMatches(string championshipId, string type = "all",
        int offset = 0, int limit = 20)
    {
        string url = Constants.GetChampionshipMatchesUrl(championshipId, type, offset, limit);
        var response = _client.GetAsync(url).GetAwaiter().GetResult();

        if (response.IsSuccessStatusCode)
        {
            return JsonConvert.DeserializeObject<InformationList<ChampionshipMatch>>(response.Content
                .ReadAsStringAsync().GetAwaiter().GetResult());
        }

        throw new Exception(response.StatusCode.ToString());
    }
}