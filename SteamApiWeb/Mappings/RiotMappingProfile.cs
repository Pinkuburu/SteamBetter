using AutoMapper;
using RiotApiClient.Models;
using SteamBetterWeb.ViewModels.Riot;

namespace SteamBetterWeb.Mappings
{
    internal class RiotMappingProfile : Profile
    {
        public RiotMappingProfile()
        {
            SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
            DestinationMemberNamingConvention = new PascalCaseNamingConvention();

            CreateMap<SummonerModel, SummonerViewModel>();

        }
    }
}
