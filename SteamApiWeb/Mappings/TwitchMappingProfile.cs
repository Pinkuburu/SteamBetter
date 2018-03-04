using AutoMapper;
using SteamBetterWeb.ViewModels.Twitch;
using TwitchApiClient.Models;

namespace SteamBetterWeb.Mappings
{
    internal class TwitchMappingProfile : Profile
    {
        public TwitchMappingProfile()
        {
            SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
            DestinationMemberNamingConvention = new PascalCaseNamingConvention();

            //CreateMap<TokenModel, TopGamesViewModel>();
            CreateMap<TopGamesModel, TopGamesViewModel>();
            CreateMap<TopGamesModel.Datum, TopGamesViewModel.Datum>();

            CreateMap<StreamsModel, StreamsViewModel>();
            CreateMap<StreamsModel.Datum, StreamsViewModel.Datum>();

        }
    }
}
