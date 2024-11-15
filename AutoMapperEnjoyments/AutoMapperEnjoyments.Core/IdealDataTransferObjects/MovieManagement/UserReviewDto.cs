namespace AutoMapperEnjoyments.Core.IdealDataTransferObjects.MovieManagement
{
    public class UserReviewDto
    {

        public int ReviewId { get; set; }

        public int UserId { get; set; }

        public int MovieId { get; set; }

        public DateTime ReviewDate { get; set; }

        public string ReviewContent { get; set; }

        public int Rating { get; set; }

        public bool IsVerified { get; set; }

        public DateTime LastEdited { get; set; }

        public List<string> Tags { get; set; }

        public string ReviewerName { get; set; }

        public bool IsSpoiler { get; set; }

        public TimeSpan WatchDuration { get; set; }
    }
}
