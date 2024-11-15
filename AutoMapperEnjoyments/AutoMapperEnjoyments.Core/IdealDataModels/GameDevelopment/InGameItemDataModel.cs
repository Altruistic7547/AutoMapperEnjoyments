namespace AutoMapperEnjoyments.Core.IdealDataModels.GameDevelopment
{
    public class InGameItemDataModel
    {

        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public string ItemType { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public short Quantity { get; set; }

        public string Rarity { get; set; }

        public int LevelRequirement { get; set; }

        public List<string> Effects { get; set; }

        public string IconUrl { get; set; }

        public bool IsTradeable { get; set; }

        public string DropRate { get; set; }
    }
}
