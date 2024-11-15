namespace AutoMapperEnjoyments.Core.IdealDataTransferObjects.GameDevelopment
{
    public class GameSubscriptionDto
    {

        public Guid SubscriptionId { get; set; }

        public int PlayerId { get; set; }

        public Guid GameId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal MonthlyCost { get; set; }

        public bool IsActive { get; set; }

        public List<string> SubscriptionBenefits { get; set; }

        public string SubscriptionType { get; set; }

        public string PaymentMethod { get; set; }

        public string Currency { get; set; }

        public DateTime RenewalDate { get; set; }
    }
}
