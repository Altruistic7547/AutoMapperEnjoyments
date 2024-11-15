namespace AutoMapperEnjoyments.Core.IdealDataModels.GameDevelopment
{
    public class GameLevelDataModel
    {

        public int LevelId { get; set; }

        public string LevelName { get; set; }

        public int GameId { get; set; }

        public string Description { get; set; }

        public byte Difficulty { get; set; }

        public TimeSpan AverageCompletionTime { get; set; }

        public List<string> Rewards { get; set; }

        public string BackgroundMusic { get; set; }

        public bool IsBossLevel { get; set; }

        public long MaxScore { get; set; }

        public List<int> Enemies { get; set; }

        public string Environment { get; set; }
    }
}
