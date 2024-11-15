namespace AutoMapperEnjoyments.Core.IdealDataTransferObjects.GameDevelopment
{
    public class GameDto
    {

        public int GameId { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public string Platform { get; set; }

        public string Developer { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int? AgeRating { get; set; }

        public decimal Price { get; set; }

        public List<string> Tags { get; set; }

        public string Description { get; set; }

        public int PlayerCount { get; set; }

        public Guid GameGuid { get; set; }
    }
}
