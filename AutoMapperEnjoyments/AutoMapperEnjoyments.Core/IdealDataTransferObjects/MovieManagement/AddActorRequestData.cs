namespace AutoMapperEnjoyments.Core.IdealDataTransferObjects.MovieManagement
{
    public class AddActorRequestData
    {
        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Nationality { get; set; }

        public List<string> Filmography { get; set; }

        public int AwardCount { get; set; }

        public bool IsActive { get; set; }

        public string Biography { get; set; }

        public DateTimeOffset CreatedDateTime { get; set; }

        public DateTimeOffset ModifiedDateTime { get; set; }

        public int ModifiedOperatorId { get; set; }
    }
}
