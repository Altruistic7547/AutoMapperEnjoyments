namespace AutoMapperEnjoyments.Core.IdealDataModels.MovieManagement
{
    public class ActorDataModel
    {

        public int ActorId { get; set; }

        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Nationality { get; set; }

        public List<string> Filmography { get; set; }

        public int AwardCount { get; set; }

        public bool IsActive { get; set; }

        public string Biography { get; set; }

        public List<string> KnownForRoles { get; set; }

        public List<AwardDataModel> Awards { get; set; }

        public string Agency { get; set; }

        public TimeSpan CareerDuration { get; set; }

        public DateTimeOffset CreatedDateTime { get; set; }

        public DateTimeOffset ModifiedDateTime { get; set; }

        public int ModifiedOperatorId { get; set; }
    }
}
