namespace AutoMapperEnjoyments.Core.IdealDataTransferObjects.MovieManagement
{
    public class ActorDto
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

        public List<AwardDto> Awards { get; set; }

        public string Agency { get; set; }

        public TimeSpan CareerDuration { get; set; }
    }
}
