using AutoMapper;
using SteamApiClient.Models;
using SteamBetterWeb.ViewModels.Games;

namespace SteamBetterWeb.Mappings
{
    internal class GamesMappingProfile : Profile
    {
        public GamesMappingProfile()
        {
            SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
            DestinationMemberNamingConvention = new PascalCaseNamingConvention();

            CreateMap<LeagueListingModel, LeagueListingViewModel>();

            CreateMap<LiveLeagueGamesModel.Game, LiveLeagueGamesViewModel.Game>();
            CreateMap<LiveLeagueGamesModel.Player, LiveLeagueGamesViewModel.Player>();
            CreateMap<LiveLeagueGamesModel.Player2, LiveLeagueGamesViewModel.Player2>();
            CreateMap<LiveLeagueGamesModel.Dire, LiveLeagueGamesViewModel.Dire>();
            CreateMap<LiveLeagueGamesModel.Dire_Team, LiveLeagueGamesViewModel.Dire_Team>();
            CreateMap<LiveLeagueGamesModel.Radiant, LiveLeagueGamesViewModel.Radiant>();
            CreateMap<LiveLeagueGamesModel.Radiant_Team, LiveLeagueGamesViewModel.Radiant_Team>();
            CreateMap<LiveLeagueGamesModel.Ability, LiveLeagueGamesViewModel.Ability>();
            CreateMap<LiveLeagueGamesModel.Pick, LiveLeagueGamesViewModel.Pick>();
            CreateMap<LiveLeagueGamesModel.Ban, LiveLeagueGamesViewModel.Ban>();
            CreateMap<LiveLeagueGamesModel.Scoreboard, LiveLeagueGamesViewModel.Scoreboard>();
    
            CreateMap<MatchDetailsModel, MatchDetailsViewModel>();

            CreateMap<PlayerStatsModel, PlayerStatsViewModel>();
            CreateMap<TeamInfoModel, TeamInfoViewModel>();

        }
    }
}
