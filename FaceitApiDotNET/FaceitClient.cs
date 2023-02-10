using System.Net.Http.Headers;
using FaceitApiDotNET.Models.Championships;
using FaceitApiDotNET.Models.GameDetails;
using FaceitApiDotNET.Models.Hubs;
using FaceitApiDotNET.Models.Leaderboard;
using FaceitApiDotNET.Models.Match;
using FaceitApiDotNET.Models.MatchDetails;
using FaceitApiDotNET.Models.MatchStats;
using FaceitApiDotNET.Models.Misc;
using FaceitApiDotNET.Models.PlayerInfo;
using FaceitApiDotNET.Models.Standalone;
using FaceitApiDotNET.Models.Tournaments;
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

    private T GetResponse<T>(string url)
    {
        var response = _client.GetAsync(url).GetAwaiter().GetResult();

        if (response.IsSuccessStatusCode)
        {
            return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync()
                .GetAwaiter().GetResult()) ?? throw new InvalidOperationException();
        }

        throw new Exception(response.StatusCode.ToString());
    }

    #region Championships

    public InformationList<Championship> GetChampionships(string game, string type = "all", int offset = 0,
        int limit = 20)
    {
        string url = Constants.GetChampionshipUrl(game, type, offset, limit);

        return GetResponse<InformationList<Championship>>(url);
    }

    public Championship GetChampionshipDetails(string championshipId, params string[] expanded)
    {
        string url = Constants.GetChampionshipDetailsUrl(championshipId, expanded);

        return GetResponse<Championship>(url);
    }

    public InformationList<ChampionshipMatch> GetChampionshipMatches(string championshipId, string type = "all",
        int offset = 0, int limit = 20)
    {
        string url = Constants.GetChampionshipMatchesUrl(championshipId, type, offset, limit);

        return GetResponse<InformationList<ChampionshipMatch>>(url);
    }

    public ChampionshipResult GetChampionshipResults(string championshipId, int offset = 0,
        int limit = 20)
    {
        string url = Constants.GetChampionshipResultsUrl(championshipId, offset, limit);

        return GetResponse<ChampionshipResult>(url);
    }

    public InformationList<ChampionshipParticipant> GetChampionshipParticipants(string championshipId, int offset = 0,
        int limit = 20)
    {
        string url = Constants.GetChampionshipSubscriptionsUrl(championshipId, offset, limit);

        return GetResponse<InformationList<ChampionshipParticipant>>(url);
    }

    #endregion

    #region Games

    public InformationList<GameDetails> GetGames(int offset = 0, int limit = 20)
    {
        string url = Constants.GetGamesUrl(offset, limit);

        return GetResponse<InformationList<GameDetails>>(url);
    }

    public GameDetails GetGameDetails(string gameId)
    {
        string url = Constants.GetGameDetailsUrl(gameId);

        return GetResponse<GameDetails>(url);
    }

    public GameDetails GetParentGame(string gameId)
    {
        string url = Constants.GetGameParentUrl(gameId);

        return GetResponse<GameDetails>(url);
    }

    #endregion

    #region Hubs

    public Hub GetHubDetails(string hubId)
    {
        string url = Constants.GetHubUrl(hubId);

        return GetResponse<Hub>(url);
    }

    public InformationList<Match> GetHubMatches(string hubId, string type = "all", int offset = 0,
        int limit = 20)
    {
        string url = Constants.GetHubMatchesUrl(hubId, type, offset, limit);

        return GetResponse<InformationList<Match>>(url);
    }

    public InformationList<HubMember> GetHubMembers(string hubId, int offset = 0, int limit = 20)
    {
        string url = Constants.GetHubMembersUrl(hubId, offset, limit);

        return GetResponse<InformationList<HubMember>>(url);
    }

    public InformationList<HubRole> GetHubRoles(string hubId, int offset = 0, int limit = 20)
    {
        string url = Constants.GetHubRolesUrl(hubId, offset, limit);

        return GetResponse<InformationList<HubRole>>(url);
    }

    public HubRule GetHubRules(string hubId)
    {
        string url = Constants.GetHubRulesUrl(hubId);

        return GetResponse<HubRule>(url);
    }

    public HubStats GetHubStats(string hubId, int offset = 0, int limit = 20)
    {
        string url = Constants.GetHubStatsUrl(hubId, offset, limit);

        return GetResponse<HubStats>(url);
    }

    #endregion

    #region Leaderboards

    public InformationList<Leaderboard> GetLeaderboardChampionship(string championshipId, int offset = 0,
        int limit = 20)
    {
        string url = Constants.GetLeaderboardsChampionshipUrl(championshipId, offset, limit);

        return GetResponse<InformationList<Leaderboard>>(url);
    }

    public GroupRankingList GetLeaderboardChampionshipGroup(string championshipId, string group, int offset = 0,
        int limit = 20)
    {
        string url = Constants.GetLeaderboardsChampionshipGroupsUrl(championshipId, group, offset, limit);

        return GetResponse<GroupRankingList>(url);
    }

    public InformationList<Leaderboard> GetLeaderboardHub(string hubId, int offset = 0, int limit = 20)
    {
        string url = Constants.GetLeaderboardsHubsUrl(hubId, offset, limit);

        return GetResponse<InformationList<Leaderboard>>(url);
    }

    public InformationList<Leaderboard> GetLeaderboardHubGeneral(string hubId, int offset = 0, int limit = 20)
    {
        string url = Constants.GetLeaderboardsHubsGeneralUrl(hubId, offset, limit);

        return GetResponse<InformationList<Leaderboard>>(url);
    }

    public InformationList<Leaderboard> GetLeaderboardHubSeasonal(string hubId, string season, int offset = 0,
        int limit = 20)
    {
        string url = Constants.GetLeaderboardsHubsSeasonalUrl(hubId, season, offset, limit);

        return GetResponse<InformationList<Leaderboard>>(url);
    }

    public InformationList<Leaderboard> GetLeaderboardHubSeasonal(string leaderboardId, int offset = 0, int limit = 20)
    {
        string url = Constants.GetLeaderboardUrl(leaderboardId, offset, limit);

        return GetResponse<InformationList<Leaderboard>>(url);
    }

    #endregion

    #region Matches

    public MatchDetails GetMatchDetails(string matchId)
    {
        string url = Constants.GetMatchDetailsUrl(matchId);

        return GetResponse<MatchDetails>(url);
    }

    public MatchStats GetMatchStats(string matchId)
    {
        string url = Constants.GetMatchStatsUrl(matchId);

        return GetResponse<MatchStats>(url);
    }

    #endregion

    #region Organizers

    public OrganizerData GetOrganizerDetailsByName(string name)
    {
        string url = Constants.GetOrganizerDetailsFromNameUrl(name);

        return GetResponse<OrganizerData>(url);
    }

    public OrganizerData GetOrganizerDetailsById(string organizerId)
    {
        string url = Constants.GetOrganizerDetailsUrl(organizerId);

        return GetResponse<OrganizerData>(url);
    }

    public InformationList<Championship> GetChampionshipsFromOrg(string organizerId, int offset = 0, int limit = 20)
    {
        string url = Constants.GetOrganizerChampionshipsUrl(organizerId, offset, limit);

        return GetResponse<InformationList<Championship>>(url);
    }

    public InformationList<GameDetails> GetGamesFromOrg(string organizerId)
    {
        string url = Constants.GetOrganizerGamesUrl(organizerId);

        return GetResponse<InformationList<GameDetails>>(url);
    }

    public InformationList<Hub> GetHubsFromOrg(string organizerId, int offset = 0, int limit = 20)
    {
        string url = Constants.GetOrganizerHubsUrl(organizerId, offset, limit);

        return GetResponse<InformationList<Hub>>(url);
    }

    public InformationList<Tournament> GetTournamentsFromOrg(string organizerId, string? type = null, int offset = 0,
        int limit = 20)
    {
        string url;
        if (type is null)
            url = Constants.GetOrganizerTournamentsUrl(organizerId, offset, limit);
        else
            url = Constants.GetOrganizerTournamentsUrl(organizerId, type, offset, limit);

        return GetResponse<InformationList<Tournament>>(url);
    }

    public Account GetPlayer(string? nickname, string? game = null, string? gamePlayerId = null)
    {
        string url;
        if (nickname is not null)
            url = Constants.GetPlayerDetailsUrl(nickname);
        else if (game is not null && gamePlayerId is not null)
            url = Constants.GetPlayerDetailsUrl(game, gamePlayerId);
        else
            throw new Exception("Nickname or Game and GamePlayerId must be set");

        return GetResponse<Account>(url);
    }

    public Account GetPlayerById(string playerId)
    {
        string url = Constants.GetPlayerDetailsByIdUrl(playerId);

        return GetResponse<Account>(url);
    }

    public InformationList<Match> GetPlayerHistory(string playerId, string game, string unixFrom = "0",
        string unixTo = "", int offset = 0, int limit = 20)
    {
        if (string.IsNullOrEmpty(unixTo))
            unixTo = DateTime.Now.Ticks.ToString();
        //string url = Constants.GetPlayerHistoryUrl(playerId, game, unixFrom, unixTo, offset, limit);
        string url = Constants.GetPlayerHistoryUrl(playerId, game, offset, limit);

        return GetResponse<InformationList<Match>>(url);
    }

    public InformationList<Hub> GetPlayerHubs(string playerId, int offset = 0, int limit = 20)
    {
        string url = Constants.GetPlayerHubsUrl(playerId, offset, limit);

        return GetResponse<InformationList<Hub>>(url);
    }

    public LifetimeStats GetPlayerStats(string playerId, string game)
    {
        string url = Constants.GetPlayerStatsUrl(playerId, game);

        return GetResponse<LifetimeStats>(url);
    }
    
    public InformationList<Tournament> GetPlayerTournaments(string playerId, int offset = 0, int limit = 20)
    {
        string url = Constants.GetPlayerTournamentsUrl(playerId, offset, limit);

        return GetResponse<InformationList<Tournament>>(url);
    }
    
    #endregion
}