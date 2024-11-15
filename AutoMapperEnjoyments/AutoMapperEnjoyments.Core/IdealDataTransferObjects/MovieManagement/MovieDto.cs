namespace AutoMapperEnjoyments.Core.IdealDataTransferObjects.MovieManagement
{
    public class MovieDto
    {

        public int MovieId { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Director { get; set; }

        public List<string> Genres { get; set; }

        public TimeSpan Duration { get; set; }

        public double Rating { get; set; }

        public string Synopsis { get; set; }

        public List<ActorDto> Cast { get; set; }

        public decimal Budget { get; set; }

        public decimal BoxOfficeRevenue { get; set; }

        public List<string> Languages { get; set; }

        public string StoryPlotDescription { get; set; }
    }
}
