namespace AutoMapperEnjoyments.Core.IdealDataModels.Purchasing
{
    public class ProductDataModel
    {

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public DateTime DateAdded { get; set; }

        public float DiscountRate { get; set; }

        public List<string> Tags { get; set; }

        public Guid SupplierId { get; set; }

        public bool IsAvailable { get; set; }

        public string ProductDescription { get; set; }

        public string SKU { get; set; }
    }
}
