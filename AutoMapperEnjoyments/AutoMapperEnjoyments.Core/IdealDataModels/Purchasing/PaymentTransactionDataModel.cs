namespace AutoMapperEnjoyments.Core.IdealDataModels.Purchasing
{
    public class PaymentTransactionDataModel
    {

        public Guid TransactionId { get; set; }

        public int OrderId { get; set; }

        public Guid CustomerId { get; set; }

        public decimal TransactionAmount { get; set; }

        public DateTime TransactionDate { get; set; }

        public bool IsSuccessful { get; set; }

        public string PaymentType { get; set; }

        public string TransactionStatus { get; set; }

        public Guid InvoiceId { get; set; }

        public string Currency { get; set; }

        public string ConfirmationNumber { get; set; }

        public DateTime? RefundDate { get; set; }
    }
}
