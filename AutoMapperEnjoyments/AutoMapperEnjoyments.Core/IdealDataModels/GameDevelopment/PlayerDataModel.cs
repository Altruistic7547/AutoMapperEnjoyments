namespace AutoMapperEnjoyments.Core.IdealDataModels.GameDevelopment
{
    public class PlayerDataModel
    {

        public int PlayerId { get; set; }

        public string Username { get; set; }

        public DateTime DateJoined { get; set; }

        public long GamesPlayed { get; set; }

        public double TotalScore { get; set; }

        public DateTime? LastLogin { get; set; }

        public List<int> Achievements { get; set; }

        public string AvatarUrl { get; set; }

        public short FriendsCount { get; set; }

        public string Region { get; set; }

        public HashSet<string> GameLibrary { get; set; }

        public char PreferredLanguage { get; set; }

        public string DescriptionLine1 { get; set; }
        
        public string DescriptionLine2 { get; set; }
        
        public string DescriptionLine3 { get; set; }
        
        public string DescriptionLine4 { get; set; }
    }
}
