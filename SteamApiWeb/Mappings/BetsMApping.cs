using AutoMapper;
using PinnacleApiClient.Models;
using SteamBetterWeb.ViewModels.Bets;

namespace SteamBetterWeb.Mappings
{
    internal class BetsMappingProfile : Profile
    {
        public BetsMappingProfile()
        {
            CreateMap<BalanceModel, BalanceViewModel>();
            CreateMap<FixturesModel, FixturesViewModel>();
            CreateMap<LeaguesModel, LeaguesViewModel>().ForMember(m => m.SportId, c => c.Ignore());
            CreateMap<LineModel, LineViewModel>();
            CreateMap<OddsModel, OddsViewModel>();
            CreateMap<SportsModel, SportsViewModel>();

        }
    }
}
