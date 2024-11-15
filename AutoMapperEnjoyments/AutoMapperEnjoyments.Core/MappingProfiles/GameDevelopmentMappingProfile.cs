using AutoMapper;
using AutoMapperEnjoyments.Core.IdealDataModels.GameDevelopment;
using AutoMapperEnjoyments.Core.IdealDataTransferObjects.GameDevelopment;

namespace AutoMapperEnjoyments.Core.MappingProfiles
{
    public class GameDevelopmentMappingProfile : Profile
    {
        public GameDevelopmentMappingProfile()
        {
            CreateMap<GameAchievementDataModel, GameAchievementDto>();

            CreateMap<GameDataModel, GameDto>();

            CreateMap<GameLevelDataModel, GameLevelDto>();

            CreateMap<GamePatchDataModel, GamePatchDto>()
                .ForMember(a => a.PatchTitle, b => b.MapFrom(z => z.Title))
                .ForMember(a => a.RequiresRestart, b => b.MapFrom(z => z.IsRestart))
                .ForMember(a => a.PatchSubVersion, b => b.Ignore())
                .ForMember(a => a.PatchOverallRating, b => b.Ignore());

            CreateMap<GameRatingDataModel, GameRatingDto>();

            CreateMap<InGamePurchaseInvoice, InGamePurchaseInvoiceDto>()
                .ForMember(a => a.InvoiceReference, s => s.MapFrom(m => m.InvoiceReference))
                .ForMember(a => a.InvoiceDate, s => s.MapFrom(m => m.InvoiceDate))
                .ForMember(a => a.PaymentReference, s => s.MapFrom(m => m.PaymentReference))
                .ForMember(a => a.InvoiceValue, s => s.MapFrom(m => m.InvoiceValue))
                .ForMember(a => a.GstValue, s => s.MapFrom(m => m.GstValue))
                .ForMember(a => a.InvoiceDescription, s => s.MapFrom(m => m.InvoiceDescription))
                .ForMember(a => a.WithholdingTaxFlag, s => s.MapFrom(m => m.WithholdingTaxFlag))
                .ReverseMap();

            CreateMap<GameSubscriptionDataModel, GameSubscriptionDto>()
                .ForMember(a => a.StartDate, b => b.MapFrom(o => DateTime.Now))
                .ForMember(a => a.EndDate, b => b.MapFrom(o => DateTime.Now.AddDays(28)))
                .ForMember(a => a.SubscriptionType, b => b.MapFrom(o => o.SubscriptionType == null ? "Free" : o.SubscriptionType))
                .ForMember(a => a.Currency, b => b.MapFrom(o => o.Currency == null ? "INR" : o.Currency));

            CreateMap<GameTransactionDataModel, GameTransactionDto>();

            CreateMap<InGameItemDataModel, InGameItemDto>();

            CreateMap<NPCDataModel, NPCDto>();

            CreateMap<PlayerDataModel, PlayerDto>()
                .ForMember(a => a.Description, o => o.MapFrom(m => string.Join(" ", new[]
                                                                            {
                                                                                m.DescriptionLine1,
                                                                                m.DescriptionLine2,
                                                                                m.DescriptionLine3,
                                                                                m.DescriptionLine4,
                                                                            }.Where(s => !string.IsNullOrWhiteSpace(s)))));
        }
    }
}
