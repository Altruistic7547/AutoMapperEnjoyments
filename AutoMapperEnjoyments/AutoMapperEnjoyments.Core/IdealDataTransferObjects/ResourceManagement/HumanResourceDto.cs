namespace AutoMapperEnjoyments.Core.IdealDataTransferObjects.ResourceManagement
{
    public class HumanResourceDto
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Position { get; set; }

        public DateTime HireDate { get; set; }

        public decimal Salary { get; set; }

        public bool IsFullTime { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Department { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsActive { get; set; }

    }
}
