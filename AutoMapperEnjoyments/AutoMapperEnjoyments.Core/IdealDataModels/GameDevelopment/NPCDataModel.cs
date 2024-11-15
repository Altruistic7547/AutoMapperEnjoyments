namespace AutoMapperEnjoyments.Core.IdealDataModels.GameDevelopment
{
    public class NPCDataModel
    {

        public int NpcId { get; set; }

        public string NpcName { get; set; }

        public string Role { get; set; }

        public string Faction { get; set; }

        public DateTime? DateAdded { get; set; }

        public string Location { get; set; }

        public string Dialogue { get; set; }

        public bool HasQuest { get; set; }

        public Dictionary<string, string> Inventory { get; set; }

        public decimal Health { get; set; }

        public float AttackStrength { get; set; }

        public bool IsHostile { get; set; }
    }
}
