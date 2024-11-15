using AutoMapper;
using AutoMapperEnjoyments.Core.MappingProfiles;

namespace AutoMapperEnjoyments.Core
{
    public static class MapperConfig
    {
        public static IMapper InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg => 
            {
                cfg.AddProfile<ExplorationMappingProfile>();

                cfg.AddProfile<ResourceManagementMappingProfile>();

                cfg.AddProfile<MovieManagementMappingProfile>();

                cfg.AddProfile<GameDevelopmentMappingProfile>();

                cfg.AddProfile<PurchasingMappingProfile>();
            });

            return config.CreateMapper();
        }
    }
}
