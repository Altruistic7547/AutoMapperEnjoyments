namespace AutoMapperEnjoyments.Core.IdealDataModels.MovieManagement
{
    public class BoxOfficeReportDataModel
    {
        private readonly SortedSet<string> _allBestPerformingCities;

        public int ReportId { get; set; }

        public int MovieId { get; set; }

        public DateTime ReportDate { get; set; }

        public decimal Revenue { get; set; }

        public decimal Cost { get; set; }

        public decimal NetProfit { get; set; }

        public int TicketsSold { get; set; }

        public string Region { get; set; }

        public List<string> TopPerformingCities { get; set; }

        public int TotalScreenings { get; set; }

        public string DistributionCompany { get; set; }

        public bool IsTrending { get; set; }

        public ICollection<string> GetCities()
        {
            return _allBestPerformingCities;
        }
    }
}
