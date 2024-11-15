namespace AutoMapperEnjoyments.Core.IdealDataTransferObjects.ResourceManagement
{
    public class ITResourceDto
    {
        public int ResourceId { get; set; }

        public string ResourceType { get; set; }

        public string AssetTag { get; set; }

        public string SerialNumber { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal Cost { get; set; }

        public DateTime WarrantyEndDate { get; set; }

        public string AssigneDto { get; set; }

        public string Location { get; set; }

        public bool IsOperational { get; set; }

        public DateTime LastMaintenanceDate { get; set; }

        public string MaintenanceProvider { get; set; }

    }
}
