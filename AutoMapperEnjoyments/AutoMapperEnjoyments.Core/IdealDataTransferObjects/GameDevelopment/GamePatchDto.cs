namespace AutoMapperEnjoyments.Core.IdealDataTransferObjects.GameDevelopment
{
    public class GamePatchDto
    {

        public int PatchId { get; set; }

        public string PatchTitle { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Description { get; set; }

        public List<string> NewFeatures { get; set; }

        public List<string> BugFixes { get; set; }

        public List<string> KnownIssues { get; set; }

        public string PatchVersion { get; set; }

        public long FileSize { get; set; }

        public bool RequiresRestart { get; set; }

        public List<string> SupportedPlatforms { get; set; }

        public List<int> AffectedLevels { get; set; }

        public decimal PatchSubVersion { get; set; }

        public sbyte PatchOverallRating { get; set; }
    }
}
