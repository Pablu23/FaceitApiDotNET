namespace FaceitApiDotNET;

public static class Constants
{
    public const string BaseUrl = "https://open.faceit.com/data/v4";

    #region Championship

    public static string GetChampionshipUrl(string game, string type, int offset, int limit) =>
        $"{BaseUrl}/championships?game={game}&type={type}&offset={offset}&limit={limit}";

    public static string GetChampionshipDetailsUrl(string championshipId, string[] expanded) =>
        $"{BaseUrl}/championships/{championshipId}?expanded={string.Join(",", expanded)}";

    public static string GetChampionshipMatchesUrl(string championshipId, string type, int offset, int limit) =>
        $"{BaseUrl}/championships/{championshipId}/matches?type={type}&offset={offset}&limit={limit}";

    public static string GetChampionshipResultsUrl(string championshipId, int offset, int limit) =>
        $"{BaseUrl}/championships/{championshipId}/results?offset={offset}&limit={limit}";

    public static string GetChampionshipSubscriptionsUrl(string championshipId, int offset, int limit) =>
        $"{BaseUrl}/championships/{championshipId}/subscriptions?offset={offset}&limit={limit}";

    #endregion

    #region Games

    public static string GetGamesUrl(int offset, int limit) => $"{BaseUrl}/games?offset={offset}&limit={limit}";

    public static string GetGameDetailsUrl(string gameId) => $"{BaseUrl}/games/{gameId}";

    public static string GetGameParentUrl(string gameId) => $"{BaseUrl}/games/{gameId}/parent";

    #endregion

    #region Hubs

    public static string GetHubUrl(string hubId) => $"{BaseUrl}/hubs/{hubId}";

    public static string GetHubMatchesUrl(string hubId, string type, int offset, int limit) =>
        $"{BaseUrl}/hubs/{hubId}/matches?type={type}&offset={offset}&limit={limit}";

    public static string GetHubMembersUrl(string hubId, string type, int offset, int limit) =>
        $"{BaseUrl}/hubs/{hubId}/members?type={type}&offset={offset}&limit={limit}";

    public static string GetHubRolesUrl(string hubId, string type, int offset, int limit) =>
        $"{BaseUrl}/hubs/{hubId}/roles?type={type}&offset={offset}&limit={limit}";

    public static string GetHubRulesUrl(string hubId) => $"{BaseUrl}/hubs/{hubId}/rules";

    public static string GetHubStatsUrl(string hubId, string type, int offset, int limit) =>
        $"{BaseUrl}/hubs/{hubId}/stats?type={type}&offset={offset}&limit={limit}";

    #endregion

    #region Leaderboards

    public static string GetLeaderboardsChampionshipUrl(string championshipId, int offset, int limit) =>
        $"{BaseUrl}/leaderboards/championships/{championshipId}?offset={offset}&limit={limit}";

    public static string GetLeaderboardsChampionshipGroupsUrl(string championshipId, string group, int offset,
        int limit) =>
        $"{BaseUrl}/leaderboards/championships/{championshipId}/groups/{group}?offset={offset}&limit={limit}";

    public static string GetLeaderboardsHubsUrl(string hubId, int offset, int limit) =>
        $"{BaseUrl}/leaderboards/hubs/{hubId}?offset={offset}&limit={limit}";

    public static string GetLeaderboardsHubsGeneralUrl(string hubId, int offset, int limit) =>
        $"{BaseUrl}/leaderboards/hubs/{hubId}/general?offset={offset}&limit={limit}";

    public static string GetLeaderboardsHubsSeasonalUrl(string hubId, string season, int offset, int limit) =>
        $"{BaseUrl}/leaderboards/hubs/{hubId}/seasons/{season}?offset={offset}&limit={limit}";

    public static string GetLeaderUrl(string leaderboardId, int offset, int limit) =>
        $"{BaseUrl}/leaderboards/{leaderboardId}?offset={offset}&limit={limit}";

    #endregion

    #region Matches

    public static string GetMatchDetailsUrl(string matchId) => $"{BaseUrl}/matches/{matchId}";

    public static string GetMatchStatsUrl(string matchId) => $"{BaseUrl}/matches/{matchId}/stats";

    #endregion

    #region Organizers

    public static string GetOrganizerDetailsFromNameUrl(string organizerName) =>
        $"{BaseUrl}/organizers?name={organizerName}";

    public static string GetOrganizerDetailsUrl(string organizerId) => $"{BaseUrl}/organizers/{organizerId}";

    public static string GetOrganizerChampionshipsUrl(string organizerId, int offset, int limit) =>
        $"{BaseUrl}/organizers/{organizerId}/championships?offset={offset}&limit={limit}";

    public static string GetOrganizerGamesUrl(string organizerId) => $"{BaseUrl}/organizers/{organizerId}/games";

    public static string GetOrganizerHubsUrl(string organizerId, int offset, int limit) =>
        $"{BaseUrl}/organizers/{organizerId}/hubs?offset={offset}&limit={limit}";

    public static string GetOrganizerHubsUrl(string organizerId, string type, int offset, int limit) =>
        $"{BaseUrl}/organizers/{organizerId}/tournaments?type={type}&offset={offset}&limit={limit}";

    #endregion

    #region Players

    public static string GetPlayerDetailsUrl(string nickname, string game, string gamePlayerId) =>
        $"{BaseUrl}/players?nickname={nickname}&game={game}&game_player_id={gamePlayerId}";

    public static string GetPlayerDetailsUrl(string playerId) => $"{BaseUrl}/players/{playerId}";

    public static string GetPlayerHistoryUrl(string playerId, string game, string unixFrom, string unixTo, int offset,
        int limit) =>
        $"{BaseUrl}/players/{playerId}/history?game={game}&from={unixFrom}&to={unixTo}&offset={offset}&limit={limit}";

    public static string GetPlayerHubsUrl(string playerId, int offset, int limit) =>
        $"{BaseUrl}/players/{playerId}/hubs?offset={offset}&limit={limit}";

    public static string GetPlayerStatsUrl(string playerId, string game) =>
        $"{BaseUrl}/players/{playerId}/stats/{game}";

    public static string GetPlayerTournamentsUrl(string playerId, int offset, int limit) =>
        $"{BaseUrl}/players/{playerId}/tournaments?offset={offset}&limit={limit}";

    #endregion

    #region Rankings

    public static string GetRankingsUrl(string game, string region, string country, int offset, int limit) =>
        $"{BaseUrl}/rankings/games/{game}/regions{region}?country={country}&offset={offset}&limit={limit}";

    public static string
        GetRankingsPositionUrl(string game, string region, string playerId, string country, int limit) =>
        $"{BaseUrl}/rankings/games/{game}/regions{region}/players/{playerId}?country={country}&limit={limit}";

    #endregion

    #region Search

    public static string GetSearchChampionshipsUrl(string name, string game, string region, string type, int offset,
        int limit) =>
        $"{BaseUrl}/search/championships?name={name}&game={game}&region={region}&type={type}&offset={offset}&limit={limit}";

    public static string GetSearchHubsUrl(string name, string game, int offset, int limit) =>
        $"{BaseUrl}/search/hubs?name={name}&game={game}&offset={offset}&limit={limit}";

    public static string GetSearchOrganizersUrl(string name, int offset, int limit) =>
        $"{BaseUrl}/search/organizers?name={name}&offset={offset}&limit={limit}";

    public static string GetSearchPlayersUrl(string nickname, string game, string country, int offset, int limit) =>
        $"{BaseUrl}/search/players?name={nickname}&game={game}&country={country}&offset={offset}&limit={limit}";

    public static string GetSearchTeamsUrl(string nickname, string game, int offset, int limit) =>
        $"{BaseUrl}/search/teams?name={nickname}&game={game}&offset={offset}&limit={limit}";

    public static string GetSearchTournamentsUrl(string name, string game, string region, string type, int offset,
        int limit) =>
        $"{BaseUrl}/search/tournaments?name={name}&game={game}&region={region}&type={type}&offset={offset}&limit={limit}";

    #endregion

    #region Teams

    public static string GetTeamDetailsUrl(string teamId) => $"{BaseUrl}/teams/{teamId}";

    public static string GetTeamStatsUrl(string teamId, string gameId) => $"{BaseUrl}/teams/{teamId}/stats/{gameId}";

    public static string GetTeamTournamentsUrl(string teamId, int offset, int limit) =>
        $"{BaseUrl}/teams/{teamId}/tournaments?offset={offset}&limit={limit}";

    #endregion

    #region Tournaments

    public static string GetTournamentsUrl(string game, string region, int offset, int limit) =>
        $"{BaseUrl}/tournaments?game={game}&region={region}&offset={offset}&limit={limit}";

    public static string GetTournamentDetailsUrl(string tournamentId, string[] expanded) =>
        $"{BaseUrl}/tournaments/{tournamentId}?expanded={string.Join(",", expanded)}";

    public static string GetTournamentBracketsUrl(string tournamentId) =>
        $"{BaseUrl}/tournaments/{tournamentId}/brackets";

    public static string GetTournamentMatchesUrl(string tournamentId, int offset, int limit) =>
        $"{BaseUrl}/tournaments/{tournamentId}/matches?offset={offset}&limit={limit}";
    
    public static string GetTournamentTeamsUrl(string tournamentId, int offset, int limit) =>
        $"{BaseUrl}/tournaments/{tournamentId}/teams?offset={offset}&limit={limit}";
    
    #endregion
}