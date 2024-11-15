using AutoMapper;
using AutoMapperEnjoyments.Core.IdealDataModels;
using AutoMapperEnjoyments.Core.IdealDataTransferObjects;

namespace AutoMapperEnjoyments.Core.MappingProfiles
{
    public class ExplorationMappingProfile : Profile
    {
        public ExplorationMappingProfile()
        {
            CreateMap<SourceTypeExploration, DestinationTypeExploration>();
        }
    }
}
