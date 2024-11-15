namespace AutoMapperEnjoyments.Core.IdealDataTransferObjects.MovieManagement
{
    public class AwardProposeDto
    {
        public short Type { get; set; }

        public string FormattedAccount { get; set; }

        public int Number { get; set; }

        public string Text { get; set; }

        public DateTimeOffset Date { get; set; }

        public DateTimeOffset? WarningStartDate { get; set; }

        public DateTimeOffset? WarningEndDate { get; set; }

        public DateTimeOffset CreationDatetime { get; set; }

        public DateTimeOffset ModifiedDatetime { get; set; }

        public int ModifiedOperatorId { get; set; }
    }
}
