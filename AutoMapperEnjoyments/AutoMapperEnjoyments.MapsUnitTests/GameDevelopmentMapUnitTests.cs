using AutoMapperEnjoyments.Core.IdealDataModels.GameDevelopment;
using AutoMapperEnjoyments.Core.IdealDataTransferObjects.GameDevelopment;
using Shouldly;

namespace AutoMapperEnjoyments.MapsUnitTests
{
    [TestClass]
    public class GameDevelopmentMapUnitTests : UnitTestBase
    {
        [TestMethod]
        public void GameDataModel_GameDto_int_Map_Test()
        {
            var source = new GameDataModel()
            {
                GameId = int.MinValue,
                PlayerCount = int.Parse("00000909"),
            };

            var destination = _mapper.Map<GameDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameDto>();

            destination.GameId.ShouldBe(source.GameId);
            destination.PlayerCount.ShouldBe(source.PlayerCount);
        }

        [TestMethod]
        public void GameDataModel_GameDto_string_Map_Test()
        {
            var source = new GameDataModel()
            {
                Title = string.Empty,
                Genre = nameof(GameDataModel.Genre),
                Platform = typeof(GameDataModel).FullName,
                Developer = "SampleString",
                Publisher = "SampleString".ToUpper(),
                Description = "[]",
            };

            var destination = _mapper.Map<GameDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameDto>();

            destination.Title.ShouldBe(source.Title);
            destination.Genre.ShouldBe(source.Genre);
            destination.Platform.ShouldBe(source.Platform);
            destination.Developer.ShouldBe(source.Developer);
            destination.Publisher.ShouldBe(source.Publisher);
            destination.Description.ShouldBe(source.Description);
        }

        [TestMethod]
        public void GameDataModel_GameDto_DateTime_Map_Test()
        {
            var source = new GameDataModel()
            {
                ReleaseDate = DateTime.Now,
            };

            var destination = _mapper.Map<GameDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameDto>();

            destination.ReleaseDate.ShouldBe(source.ReleaseDate);
        }

        [TestMethod]
        public void GameDataModel_GameDto_decimal_Map_Test()
        {
            var source = new GameDataModel()
            {
                Price = 123.45m,
            };

            var destination = _mapper.Map<GameDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameDto>();

            destination.Price.ShouldBe(source.Price);
        }

        [TestMethod]
        public void GameDataModel_GameDto_Guid_Map_Test()
        {
            var source = new GameDataModel()
            {
                GameGuid = Guid.Empty,
            };

            var destination = _mapper.Map<GameDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameDto>();

            destination.GameGuid.ShouldBe(source.GameGuid);
        }

        [TestMethod]
        public void GameDataModel_GameDto_Null_Map_Test()
        {
            GameDataModel source = null;

            var destination = _mapper.Map<GameDto>(source);

            destination.ShouldBeNull();
        }

        [TestMethod]
        public void PlayerDataModel_PlayerDto_int_Map_Test()
        {
            var source = new PlayerDataModel()
            {
                PlayerId = int.Min(0,0)
            };

            var destination = _mapper.Map<PlayerDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PlayerDto>();

            destination.PlayerId.ShouldBe(source.PlayerId);
        }

        [TestMethod]
        public void PlayerDataModel_PlayerDto_string_Map_Test()
        {
            var source = new PlayerDataModel()
            {
                Username = String.Concat("Nice ", "To ", "Meeeeet ", "You!!"),
                AvatarUrl = Enumerable.Repeat('T',3).ToString(),
                Region = String.Empty,
            };

            var destination = _mapper.Map<PlayerDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PlayerDto>();

            destination.Username.ShouldBe(source.Username);
            destination.AvatarUrl.ShouldBe(source.AvatarUrl);
            destination.Region.ShouldBe(source.Region);
        }

        [TestMethod]
        public void PlayerDataModel_PlayerDto_DateTime_Map_Test()
        {
            var source = new PlayerDataModel()
            {
                DateJoined = new DateTime().AddYears(200),
            };

            var destination = _mapper.Map<PlayerDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PlayerDto>();

            destination.DateJoined.ShouldBe(source.DateJoined);
        }

        [TestMethod]
        public void PlayerDataModel_PlayerDto_long_Map_Test()
        {
            var source = new PlayerDataModel()
            {
                GamesPlayed = long.MinValue
            };

            var destination = _mapper.Map<PlayerDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PlayerDto>();

            destination.GamesPlayed.ShouldBe(source.GamesPlayed);
        }

        [TestMethod]
        public void PlayerDataModel_PlayerDto_double_Map_Test()
        {
            var source = new PlayerDataModel()
            {
                TotalScore = double.Epsilon
            };

            var destination = _mapper.Map<PlayerDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PlayerDto>();

            destination.TotalScore.ShouldBe(source.TotalScore);
        }

        [TestMethod]
        public void PlayerDataModel_PlayerDto_ListOfint_Map_Test()
        {
            var source = new PlayerDataModel()
            {
                Achievements = new() { 2,3,4,555},
            };

            var destination = _mapper.Map<PlayerDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PlayerDto>();

            destination.Achievements.ShouldBe(source.Achievements);
        }

        [TestMethod]
        public void PlayerDataModel_PlayerDto_short_Map_Test()
        {
            var source = new PlayerDataModel()
            {
                FriendsCount = short.MinValue,
            };

            var destination = _mapper.Map<PlayerDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PlayerDto>();

            destination.FriendsCount.ShouldBe(source.FriendsCount);
        }

        [TestMethod]
        public void PlayerDataModel_PlayerDto_HashSetOfstring_Map_Test()
        {
            var source = new PlayerDataModel()
            {
                GameLibrary = new HashSet<string>(),
            };

            var destination = _mapper.Map<PlayerDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PlayerDto>();

            destination.GameLibrary.ShouldBe(source.GameLibrary);
        }

        [TestMethod]
        public void PlayerDataModel_PlayerDto_char_Map_Test()
        {
            var source = new PlayerDataModel()
            {
                PreferredLanguage = default,
            };

            var destination = _mapper.Map<PlayerDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<PlayerDto>();

            destination.PreferredLanguage.ShouldBe(source.PreferredLanguage);
        }

        [TestMethod]
        public void PlayerDataModel_PlayerDto_Null_Map_Test()
        {
            PlayerDataModel source = null;

            var destination = _mapper.Map<PlayerDto>(source);

            destination.ShouldBeNull();
        }

        [TestMethod]
        public void PlayerDataModel_PlayerDto_List_Map_Test()
        {
            var sourceList = new List<PlayerDataModel>()
            {
                new PlayerDataModel()
                {
                    PlayerId = 123,
                    Username = "name".Remove(2),
                    DateJoined = DateTime.Now.AddYears(byte.MinValue),
                    GamesPlayed = default,
                    TotalScore = double.Pi,
                    LastLogin = DateTime.MinValue.AddYears(34),
                    Achievements = new(){ int.MinValue, int.MaxValue },
                    AvatarUrl = new Uri("http://www.Example.org/test?UnitTest=automapper").ToString(),
                    FriendsCount = short.MaxValue,
                    Region = "SampleString",
                    GameLibrary = new HashSet<string>(),
                    PreferredLanguage = char.Parse("^"),
                }
            };

            var destinationList = _mapper.Map<List<PlayerDto>>(sourceList);

            destinationList.ShouldNotBeNull();
            destinationList.Count.ShouldBe(sourceList.Count);

            for (int i = 0; i < sourceList.Count; i++)
            {
                destinationList[i].PlayerId.ShouldBe(sourceList[i].PlayerId);
                destinationList[i].Username.ShouldBe(sourceList[i].Username);
                destinationList[i].DateJoined.ShouldBe(sourceList[i].DateJoined);
                destinationList[i].GamesPlayed.ShouldBe(sourceList[i].GamesPlayed);
                destinationList[i].TotalScore.ShouldBe(sourceList[i].TotalScore);
                destinationList[i].LastLogin.ShouldBe(sourceList[i].LastLogin);
                destinationList[i].Achievements.ShouldBe(sourceList[i].Achievements);
                destinationList[i].AvatarUrl.ShouldBe(sourceList[i].AvatarUrl);
                destinationList[i].FriendsCount.ShouldBe(sourceList[i].FriendsCount);
                destinationList[i].Region.ShouldBe(sourceList[i].Region);
                destinationList[i].GameLibrary.ShouldBe(sourceList[i].GameLibrary);
                destinationList[i].PreferredLanguage.ShouldBe(sourceList[i].PreferredLanguage);
            }
        }

        [TestMethod]
        public void GameLevelDataModel_GameLevelDto_int_Map_Test()
        {
            var source = new GameLevelDataModel()
            {
                LevelId = 123,
                GameId = 123,
            };

            var destination = _mapper.Map<GameLevelDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameLevelDto>();

            destination.LevelId.ShouldBe(source.LevelId);
            destination.GameId.ShouldBe(source.GameId);
        }

        [TestMethod]
        public void GameLevelDataModel_GameLevelDto_string_Map_Test()
        {
            var source = new GameLevelDataModel()
            {
                LevelName = "SampleString",
                Description = "SampleString",
                BackgroundMusic = "SampleString",
                Environment = "SampleString",
            };

            var destination = _mapper.Map<GameLevelDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameLevelDto>();

            destination.LevelName.ShouldBe(source.LevelName);
            destination.Description.ShouldBe(source.Description);
            destination.BackgroundMusic.ShouldBe(source.BackgroundMusic);
            destination.Environment.ShouldBe(source.Environment);
        }

        [TestMethod]
        public void GameLevelDataModel_GameLevelDto_byte_Map_Test()
        {
            var source = new GameLevelDataModel()
            {
                Difficulty = default,
            };

            var destination = _mapper.Map<GameLevelDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameLevelDto>();

            destination.Difficulty.ShouldBe(source.Difficulty);
        }

        [TestMethod]
        public void GameLevelDataModel_GameLevelDto_TimeSpan_Map_Test()
        {
            var source = new GameLevelDataModel()
            {
                AverageCompletionTime = default,
            };

            var destination = _mapper.Map<GameLevelDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameLevelDto>();

            destination.AverageCompletionTime.ShouldBe(source.AverageCompletionTime);
        }

        [TestMethod]
        public void GameLevelDataModel_GameLevelDto_ListOfstring_Map_Test()
        {
            var source = new GameLevelDataModel()
            {
                Rewards = new List<string>() { string.Empty, "string.Empty", ""},
            };

            var destination = _mapper.Map<GameLevelDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameLevelDto>();

            destination.Rewards.ShouldBe(source.Rewards);
        }

        [TestMethod]
        public void GameLevelDataModel_GameLevelDto_bool_Map_Test()
        {
            var source = new GameLevelDataModel()
            {
                IsBossLevel = true,
            };

            var destination = _mapper.Map<GameLevelDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameLevelDto>();

            destination.IsBossLevel.ShouldBe(source.IsBossLevel);
        }

        [TestMethod]
        public void GameLevelDataModel_GameLevelDto_long_Map_Test()
        {
            var source = new GameLevelDataModel()
            {
                MaxScore = default,
            };

            var destination = _mapper.Map<GameLevelDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameLevelDto>();

            destination.MaxScore.ShouldBe(source.MaxScore);
        }

        [TestMethod]
        public void GameLevelDataModel_GameLevelDto_ListOfint_Map_Test()
        {
            var source = new GameLevelDataModel()
            {
                Enemies = new List<int>() { short.MinValue, short.MaxValue, byte.MinValue, byte.MaxValue},
            };

            var destination = _mapper.Map<GameLevelDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameLevelDto>();

            destination.Enemies.ShouldBe(source.Enemies);
        }

        [TestMethod]
        public void GameLevelDataModel_GameLevelDto_Null_Map_Test()
        {
            GameLevelDataModel source = null;

            var destination = _mapper.Map<GameLevelDto>(source);

            destination.ShouldBeNull();
        }

        [TestMethod]
        public void GameLevelDataModel_GameLevelDto_List_Map_Test()
        {
            var sourceList = new List<GameLevelDataModel>()
            {
                new GameLevelDataModel()
                {
                    LevelId = 123,
                    LevelName = "SampleString",
                    GameId = 123,
                    Description = "SampleString",
                    Difficulty = default,
                    AverageCompletionTime = default,
                    BackgroundMusic = "SampleString",
                    IsBossLevel = true,
                    MaxScore = default,
                    Environment = "SampleString",
                }
            };

            var destinationList = _mapper.Map<List<GameLevelDto>>(sourceList);

            destinationList.ShouldNotBeNull();
            destinationList.Count.ShouldBe(sourceList.Count);

            for (int i = 0; i < sourceList.Count; i++)
            {
                destinationList[i].LevelId.ShouldBe(sourceList[i].LevelId);
                destinationList[i].LevelName.ShouldBe(sourceList[i].LevelName);
                destinationList[i].GameId.ShouldBe(sourceList[i].GameId);
                destinationList[i].Description.ShouldBe(sourceList[i].Description);
                destinationList[i].Difficulty.ShouldBe(sourceList[i].Difficulty);
                destinationList[i].AverageCompletionTime.ShouldBe(sourceList[i].AverageCompletionTime);
                destinationList[i].BackgroundMusic.ShouldBe(sourceList[i].BackgroundMusic);
                destinationList[i].IsBossLevel.ShouldBe(sourceList[i].IsBossLevel);
                destinationList[i].MaxScore.ShouldBe(sourceList[i].MaxScore);
                destinationList[i].Environment.ShouldBe(sourceList[i].Environment);
            }
        }

        [TestMethod]
        public void GameAchievementDataModel_GameAchievementDto_int_Map_Test()
        {
            var source = new GameAchievementDataModel()
            {
                AchievementId = int.MaxValue,
            };

            var destination = _mapper.Map<GameAchievementDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameAchievementDto>();

            destination.AchievementId.ShouldBe(source.AchievementId);
        }

        [TestMethod]
        public void GameAchievementDataModel_GameAchievementDto_string_Map_Test()
        {
            var source = new GameAchievementDataModel()
            {
                Title = "SampleString",
                Description = "SampleString",
                IconUrl = "SampleString",
                AchievementType = "SampleString",
                Category = "SampleString",
            };

            var destination = _mapper.Map<GameAchievementDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameAchievementDto>();

            destination.Title.ShouldBe(source.Title);
            destination.Description.ShouldBe(source.Description);
            destination.IconUrl.ShouldBe(source.IconUrl);
            destination.AchievementType.ShouldBe(source.AchievementType);
            destination.Category.ShouldBe(source.Category);
        }

        [TestMethod]
        public void GameAchievementDataModel_GameAchievementDto_float_Map_Test()
        {
            var source = new GameAchievementDataModel()
            {
                Points = default,
            };

            var destination = _mapper.Map<GameAchievementDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameAchievementDto>();

            destination.Points.ShouldBe(source.Points);
        }

        [TestMethod]
        public void GameAchievementDataModel_GameAchievementDto_bool_Map_Test()
        {
            var source = new GameAchievementDataModel()
            {
                IsHidden = true,
            };

            var destination = _mapper.Map<GameAchievementDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameAchievementDto>();

            destination.IsHidden.ShouldBe(source.IsHidden);
        }

        [TestMethod]
        public void GameAchievementDataModel_GameAchievementDto_DateTime_Map_Test()
        {
            var source = new GameAchievementDataModel()
            {
                UnlockDate = DateTime.Now,
            };

            var destination = _mapper.Map<GameAchievementDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameAchievementDto>();

            destination.UnlockDate.ShouldBe(source.UnlockDate);
        }

        [TestMethod]
        public void GameAchievementDataModel_GameAchievementDto_Guid_Map_Test()
        {
            var source = new GameAchievementDataModel()
            {
                GameId = default,
            };

            var destination = _mapper.Map<GameAchievementDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameAchievementDto>();

            destination.GameId.ShouldBe(source.GameId);
        }

        [TestMethod]
        public void GameAchievementDataModel_GameAchievementDto_short_Map_Test()
        {
            var source = new GameAchievementDataModel()
            {
                RequiredLevel = default,
            };

            var destination = _mapper.Map<GameAchievementDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<GameAchievementDto>();

            destination.RequiredLevel.ShouldBe(source.RequiredLevel);
        }

        [TestMethod]
        public void GameAchievementDataModel_GameAchievementDto_Null_Map_Test()
        {
            GameAchievementDataModel source = null;

            var destination = _mapper.Map<GameAchievementDto>(source);

            destination.ShouldBeNull();
        }

        [TestMethod]
        public void NPCDataModel_NPCDto_int_Map_Test()
        {
            var source = new NPCDataModel()
            {
                NpcId = 123,
            };

            var destination = _mapper.Map<NPCDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<NPCDto>();

            destination.NpcId.ShouldBe(source.NpcId);
        }

        [TestMethod]
        public void NPCDataModel_NPCDto_string_Map_Test()
        {
            var source = new NPCDataModel()
            {
                NpcName = "SampleString",
                Role = "SampleString",
                Faction = "SampleString",
                Location = "SampleString",
                Dialogue = "SampleString",
            };

            var destination = _mapper.Map<NPCDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<NPCDto>();

            destination.NpcName.ShouldBe(source.NpcName);
            destination.Role.ShouldBe(source.Role);
            destination.Faction.ShouldBe(source.Faction);
            destination.Location.ShouldBe(source.Location);
            destination.Dialogue.ShouldBe(source.Dialogue);
        }

        [TestMethod]
        public void NPCDataModel_NPCDto_DateTime_Map_Test()
        {
            var source = new NPCDataModel()
            {
                DateAdded = default,
            };

            var destination = _mapper.Map<NPCDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<NPCDto>();

            destination.DateAdded.ShouldBe(source.DateAdded);
        }

        [TestMethod]
        public void NPCDataModel_NPCDto_bool_Map_Test()
        {
            var source = new NPCDataModel()
            {
                HasQuest = true,
                IsHostile = false,
            };

            var destination = _mapper.Map<NPCDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<NPCDto>();

            destination.HasQuest.ShouldBe(source.HasQuest);
            destination.IsHostile.ShouldBe(source.IsHostile);
        }

        [TestMethod]
        public void NPCDataModel_NPCDto_decimal_Map_Test()
        {
            var source = new NPCDataModel()
            {
                Health = 123.45m,
            };

            var destination = _mapper.Map<NPCDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<NPCDto>();

            destination.Health.ShouldBe(source.Health);
        }

        [TestMethod]
        public void NPCDataModel_NPCDto_float_Map_Test()
        {
            var source = new NPCDataModel()
            {
                AttackStrength = default,
            };

            var destination = _mapper.Map<NPCDto>(source);

            destination.ShouldNotBeNull();
            destination.ShouldBeOfType<NPCDto>();

            destination.AttackStrength.ShouldBe(source.AttackStrength);
        }

        [TestMethod]
        public void NPCDataModel_NPCDto_Null_Map_Test()
        {
            NPCDataModel source = null;

            var destination = _mapper.Map<NPCDto>(source);

            destination.ShouldBeNull();
        }

        [TestMethod]
        public void NPCDataModel_NPCDto_List_Map_Test()
        {
            var sourceList = new List<NPCDataModel>()
            {
                new NPCDataModel()
                {
                    NpcId = 123,
                    NpcName = "SampleString",
                    Role = "SampleString",
                    Faction = "SampleString",
                    DateAdded = default,
                    Location = "SampleString",
                    Dialogue = "SampleString",
                    HasQuest = true,
                    Inventory = new Dictionary<string, string>(),
                    Health = 123.45m,
                    AttackStrength = default,
                    IsHostile = true,
                }
            };

            var destinationList = _mapper.Map<List<NPCDto>>(sourceList);

            destinationList.ShouldNotBeNull();
            destinationList.Count.ShouldBe(sourceList.Count);

            for (int i = 0; i < sourceList.Count; i++)
            {
                destinationList[i].NpcId.ShouldBe(sourceList[i].NpcId);
                destinationList[i].NpcName.ShouldBe(sourceList[i].NpcName);
                destinationList[i].Role.ShouldBe(sourceList[i].Role);
                destinationList[i].Faction.ShouldBe(sourceList[i].Faction);
                destinationList[i].DateAdded.ShouldBe(sourceList[i].DateAdded);
                destinationList[i].Location.ShouldBe(sourceList[i].Location);
                destinationList[i].Dialogue.ShouldBe(sourceList[i].Dialogue);
                destinationList[i].HasQuest.ShouldBe(sourceList[i].HasQuest);
                destinationList[i].Inventory.ShouldBe(sourceList[i].Inventory);
                destinationList[i].Health.ShouldBe(sourceList[i].Health);
                destinationList[i].AttackStrength.ShouldBe(sourceList[i].AttackStrength);
                destinationList[i].IsHostile.ShouldBe(sourceList[i].IsHostile);
            }
        }
    }
}
