namespace AutoMapperEnjoyments.Core.IdealDataModels.Purchasing
{
    public class CustomerProfileDataModel
    {

        public Guid CustomerId { get; set; }

        public string FullName { get; set; }

        public DateTime DateOfRegistration { get; set; }

        public DateTime? LastPurchaseDate { get; set; }

        public string Email { get; set; }

        public List<string> PreferredPaymentMethods { get; set; }

        public List<Guid> OrderHistory { get; set; }

        public bool IsLoyaltyProgramMember { get; set; }

        public decimal TotalSpent { get; set; }

        public short Rating { get; set; }

        public string Address { get; set; }

        public string AddressType { get; set; }

        public char VIPStatus { get; set; }
    }
}
