using AutoMapper;
using PinnacleApiClient.Models;
using SteamBetterWeb.ViewModels.Bets;

namespace SteamBetterWeb
{
    public class AutoMapperConfig
    {
        public static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(cfg => { cfg.AddProfile<MappingProfile>(); });
            return config.CreateMapper();
        }

        private class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<BalanceModel, BalanceViewModel>();
                CreateMap<FixturesModel, FixturesViewModel>();
                CreateMap<LeaguesModel, LeaguesViewModel>();
                CreateMap<LineModel, LineViewModel>();
                CreateMap<OddsModel, OddsViewModel>();
                CreateMap<SportsModel, SportsViewModel>();

            }
        }
    }
}
