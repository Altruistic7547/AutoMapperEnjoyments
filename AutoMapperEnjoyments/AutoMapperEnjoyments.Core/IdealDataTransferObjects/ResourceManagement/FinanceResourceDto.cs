namespace AutoMapperEnjoyments.Core.IdealDataTransferObjects.ResourceManagement
{
    public class FinanceResourceDto
    {
        public int BudgetId { get; set; }

        public decimal AllocatedAmount { get; set; }

        public decimal SpentAmount { get; set; }

        public decimal RemainingAmount { get; set; }

        public string BudgetType { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string ManagerName { get; set; }

        public bool IsApproved { get; set; }

        public DateTime ApprovalDate { get; set; }

        public string ProjectName { get; set; }

        public string Currency { get; set; }

    }
}
