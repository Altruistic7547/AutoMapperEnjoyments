namespace AutoMapperEnjoyments.Core.IdealDataModels.ResourceManagement
{
    public class PhysicalResourceDataModel
    {
        public int FacilityId { get; set; }

        public string FacilityName { get; set; }

        public string FacilityType { get; set; }

        public decimal TotalArea { get; set; }

        public decimal UtilizedArea { get; set; }

        public string Location { get; set; }

        public bool IsLeased { get; set; }

        public DateTime LeaseStartDate { get; set; }

        public DateTime LeaseEndDate { get; set; }

        public decimal LeaseAmount { get; set; }

        public string OwnerContact { get; set; }

        public bool IsAvailable { get; set; }

    }
}
