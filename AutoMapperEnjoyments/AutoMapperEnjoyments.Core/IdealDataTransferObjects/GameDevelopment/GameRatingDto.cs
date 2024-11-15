namespace AutoMapperEnjoyments.Core.IdealDataTransferObjects.GameDevelopment
{
    public class GameRatingDto
    {

        public int RatingId { get; set; }

        public Guid GameId { get; set; }

        public int PlayerId { get; set; }

        public decimal RatingValue { get; set; }

        public DateTime RatedAt { get; set; }

        public string ReviewText { get; set; }

        public bool IsVerified { get; set; }

        public string ReviewTitle { get; set; }

        public DateTime LastModified { get; set; }

        public short SentimentScore { get; set; }

        public string ReviewCategory { get; set; }

        public string Tags { get; set; }
    }
}
