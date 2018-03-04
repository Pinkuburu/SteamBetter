using AutoMapper;

namespace SteamBetterWeb.Mappings
{
    public static class AutoMapperConfig
    {
        public static IMapper CreateBetsMapper()
        {
            var config = new MapperConfiguration(cfg => { cfg.AddProfile<BetsMappingProfile>(); });
            config.AssertConfigurationIsValid();
            return config.CreateMapper();
        }
        
        public static IMapper CreateGamesMapper()
        {
            var config = new MapperConfiguration(cfg => { cfg.AddProfile<GamesMappingProfile>(); });
            config.AssertConfigurationIsValid();
            return config.CreateMapper();
        }

        public static IMapper CreateTwitchMapper()
        {
            var config = new MapperConfiguration(cfg => { cfg.AddProfile<TwitchMappingProfile>(); });
            config.AssertConfigurationIsValid();
            return config.CreateMapper();
        }

    }
}
