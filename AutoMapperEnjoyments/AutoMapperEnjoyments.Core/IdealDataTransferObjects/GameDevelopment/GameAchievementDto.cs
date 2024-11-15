namespace AutoMapperEnjoyments.Core.IdealDataTransferObjects.GameDevelopment
{
    public class GameAchievementDto
    {

        public int AchievementId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public float Points { get; set; }

        public bool IsHidden { get; set; }

        public DateTime UnlockDate { get; set; }

        public Guid GameId { get; set; }

        public short RequiredLevel { get; set; }

        public string IconUrl { get; set; }

        public List<string> Conditions { get; set; }

        public string AchievementType { get; set; }

        public string Category { get; set; }
    }
}
