namespace AutoMapperEnjoyments.Core.IdealDataModels.MovieManagement
{
    public class AwardProposeDataModel
    {
        public short TypeId { get; set; }

        public string FormattedAccount { get; set; }

        public int Number { get; set; }

        public short SequenceNumber { get; set; }

        public string Text { get; set; }

        public DateTimeOffset Date { get; set; }

        public DateTimeOffset? StartDate { get; set; }

        public DateTimeOffset? EndDate { get; set; }

        public DateTimeOffset CreatedDatetime { get; set; }

        public DateTimeOffset ModifiedDatetime { get; set; }

        public int ModifiedOperatorId { get; set; }
    }
}
