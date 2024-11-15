namespace AutoMapperEnjoyments.Core.IdealDataTransferObjects.Purchasing
{
    public class PurchaseOrderDto
    {

        public int OrderId { get; set; }

        public Guid CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? ShipmentDate { get; set; }

        public decimal TotalAmount { get; set; }

        public string OrderStatus { get; set; }

        public List<string> ProductList { get; set; }

        public bool IsGiftWrapped { get; set; }

        public string ShippingAddress { get; set; }

        public decimal TaxAmount { get; set; }

        public Guid TransactionId { get; set; }

        public char OrderPriority { get; set; }
    }
}
