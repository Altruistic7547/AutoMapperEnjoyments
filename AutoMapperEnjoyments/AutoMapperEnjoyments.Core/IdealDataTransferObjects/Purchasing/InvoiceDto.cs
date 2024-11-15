namespace AutoMapperEnjoyments.Core.IdealDataTransferObjects.Purchasing
{
    public class InvoiceDto
    {

        public int InvoiceId { get; set; }

        public Guid OrderId { get; set; }

        public DateTime InvoiceDate { get; set; }

        public decimal AmountDue { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsPaid { get; set; }

        public string PaymentMethod { get; set; }

        public Guid CustomerId { get; set; }

        public List<string> LineItems { get; set; }

        public decimal LateFee { get; set; }

        public short CurrencyCode { get; set; }

        public string Notes { get; set; }

        public Guid SupplierId { get; set; }

        public bool IsAvailable { get; set; }

        public string ProductDescription { get; set; }


    }
}
