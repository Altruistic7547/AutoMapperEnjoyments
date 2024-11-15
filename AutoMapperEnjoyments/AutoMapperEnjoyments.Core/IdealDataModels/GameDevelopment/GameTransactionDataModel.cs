namespace AutoMapperEnjoyments.Core.IdealDataModels.GameDevelopment
{
    public class GameTransactionDataModel
    {

        public Guid TransactionId { get; set; }

        public int PlayerId { get; set; }

        public decimal Amount { get; set; }

        public string TransactionType { get; set; }

        public DateTime TransactionDate { get; set; }

        public bool IsSuccess { get; set; }

        public string PaymentMethod { get; set; }

        public string TransactionStatus { get; set; }

        public string Currency { get; set; }

        public string TransactionReference { get; set; }

        public long GameId { get; set; }

        public short DiscountApplied { get; set; }
    }
}
