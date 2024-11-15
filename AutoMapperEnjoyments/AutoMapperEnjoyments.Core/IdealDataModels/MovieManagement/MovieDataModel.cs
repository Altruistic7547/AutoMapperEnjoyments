using AutoMapperEnjoyments.Core.IdealDataTransferObjects.MovieManagement;

namespace AutoMapperEnjoyments.Core.IdealDataModels.MovieManagement
{
    public class MovieDataModel
    {

        public int MovieId { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Director { get; set; }

        public List<string> Genres { get; set; }

        public TimeSpan Duration { get; set; }

        public double Rating { get; set; }

        public string Synopsis { get; set; }

        public List<ActorDataModel> Cast { get; set; }

        public decimal Budget { get; set; }

        public decimal BoxOfficeRevenue { get; set; }

        public List<string> Languages { get; set; }

        public string DescriptionLine1 { get; set; }
        
        public string DescriptionLine2 { get; set; }
        
        public string DescriptionLine3 { get; set; }
        
        public string DescriptionLine4 { get; set; }

        public IEnumerable<ActorDto> Actors()
        {
            return Enumerable.Empty<ActorDto>(); 
        }
    }
}
