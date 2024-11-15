using AutoMapper;
using AutoMapperEnjoyments.Core.IdealDataModels.ResourceManagement;
using AutoMapperEnjoyments.Core.IdealDataTransferObjects.ResourceManagement;

namespace AutoMapperEnjoyments.Core.MappingProfiles
{
    public class ResourceManagementMappingProfile : Profile
    {
        public ResourceManagementMappingProfile()
        {
            CreateMap<FinanceResourceDataModel, FinanceResourceDto>();

            CreateMap<HumanResourceDataModel, HumanResourceDto>();

            CreateMap<ITResourceDataModel, ITResourceDto>();

            CreateMap<PhysicalResourceDataModel, PhysicalResourceDto>();

            CreateMap<SupplyChainResourceDataModel, SupplyChainResourceDto>();
        }
    }
}
