namespace AutoMapperEnjoyments.Core.IdealDataTransferObjects.Purchasing
{
    public class SupplierInformationDto
    {

        public Guid SupplierId { get; set; }

        public string CompanyName { get; set; }

        public string ContactPerson { get; set; }

        public string ContactEmail { get; set; }

        public DateTime ContractStartDate { get; set; }

        public DateTime? ContractEndDate { get; set; }

        public List<int> SuppliedProductIds { get; set; }

        public bool IsPreferredSupplier { get; set; }

        public string PhoneNumber { get; set; }

        public short SupplierRating { get; set; }

        public string Country { get; set; }

        public List<string> Certifications { get; set; }
    }
}
