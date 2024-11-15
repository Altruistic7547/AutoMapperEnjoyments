namespace AutoMapperEnjoyments.Core.IdealDataModels.ResourceManagement
{
    public class SupplyChainResourceDataModel
    {
        public int SupplyId { get; set; }

        public string ItemName { get; set; }

        public string SupplierName { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime ExpectedDeliveryDate { get; set; }

        public string WarehouseLocation { get; set; }

        public bool IsDelivered { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string ShipmentTrackingNumber { get; set; }

        public string Category { get; set; }

    }
}
