using AutoMapper;
using AutoMapperEnjoyments.Core.IdealDataModels.MovieManagement;
using AutoMapperEnjoyments.Core.IdealDataTransferObjects.MovieManagement;

namespace AutoMapperEnjoyments.Core.MappingProfiles
{
    public class MovieManagementMappingProfile : Profile
    {
        public MovieManagementMappingProfile()
        {
            CreateMap<ActorDataModel, ActorDto>();

            CreateMap<AddActorRequestData, ActorDataModel>()
                .ForMember(a => a.ActorId, b => b.Ignore())
                .ForMember(a => a.KnownForRoles, b => b.Ignore())
                .ForMember(a => a.Awards, b => b.Ignore())
                .ForMember(a => a.Agency, b => b.Ignore())
                .ForMember(a => a.CareerDuration, b => b.MapFrom(m => new TimeSpan().Add(TimeSpan.MaxValue)))
                .ForMember(a => a.CreatedDateTime, o => o.MapFrom(s => DateTimeOffset.Now))
                .ForMember(a => a.ModifiedDateTime, o => o.MapFrom(s => DateTimeOffset.Now))
                .ForMember(a => a.ModifiedOperatorId, o =>
                {
                    o.PreCondition(src => src.ModifiedOperatorId > 0);
                    o.MapFrom(s => s.ModifiedOperatorId);
                });


            CreateMap<AwardDataModel, AwardDto>();

            CreateMap<IGrouping<AwardProposeRequest, AwardProposeDataModel>, AwardProposeDto>()
                .ForMember(a => a.Type, m => m.MapFrom(x => x.FirstOrDefault().TypeId))
                .ForMember(a => a.FormattedAccount, m => m.MapFrom(x => x.FirstOrDefault().FormattedAccount))
                .ForMember(a => a.Number, m => m.MapFrom(x => x.FirstOrDefault().Number))
                .ForMember(a => a.Text, m => m.MapFrom(x => x.OrderBy(o => o.SequenceNumber).Select(s => s.Text).Aggregate((param1, param2) => string.Concat(param1, param2))))
                .ForMember(a => a.Date, m => m.MapFrom(x => x.FirstOrDefault().Date))
                .ForMember(a => a.WarningStartDate, m => m.MapFrom(x => x.FirstOrDefault().StartDate))
                .ForMember(a => a.WarningEndDate, m => m.MapFrom(x => x.FirstOrDefault().EndDate))
                .ForMember(a => a.CreationDatetime, m => m.MapFrom(x => x.FirstOrDefault().CreatedDatetime))
                .ForMember(a => a.ModifiedDatetime, m => m.MapFrom(x => x.FirstOrDefault().ModifiedDatetime))
                .ForMember(a => a.ModifiedOperatorId, m => m.MapFrom(x => x.FirstOrDefault().ModifiedOperatorId));


            CreateMap<BoxOfficeReportDataModel, BoxOfficeReportDto>()
                .ForMember(a => a.TopPerformingCities, m => m.MapFrom(z => z.GetCities()));

            CreateMap<MovieDataModel, MovieDto>()
                .ForMember(m => m.StoryPlotDescription, o => 
                o.MapFrom(m => $"{m.Title} {m.Director} : {m.DescriptionLine1} \n {m.DescriptionLine2} \n {m.DescriptionLine3} \n {m.DescriptionLine4}"));

            CreateMap<MovieScreeningDataModel, MovieScreeningDto>()
                               .ForMember(a => a.IntermissionDuration, o => o.MapFrom(m => "PAY." + m.IntermissionDuration.ToString().PadLeft(8, '0')))
                               .ForMember(a => a.FormattedName, o => 
                               o.MapFrom(m => (new[] { m.FormatName1, m.FormatName2,}).Concatenate().RemoveDuplicateSpaces()));


            CreateMap<UserReviewDataModel, UserReviewDto>()
                .ForMember(m => m.IsVerified, o => o.MapFrom(z => z.VerificationFlag == "Y"));
        }
    }
}
