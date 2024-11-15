namespace AutoMapperEnjoyments.Core.IdealDataModels.MovieManagement
{
    public class MovieScreeningDataModel
    {

        public int ScreeningId { get; set; }

        public int TheaterId { get; set; }

        public int MovieId { get; set; }

        public string FormatName1 { get; set; }

        public string FormatName2 { get; set; }
        
        public DateTime ShowDateTime { get; set; }

        public string HallName { get; set; }

        public int AvailableSeats { get; set; }

        public decimal TicketPrice { get; set; }

        public string Format { get; set; }

        public List<string> Subtitles { get; set; }

        public TimeSpan IntermissionDuration { get; set; }

        public bool IsSoldOut { get; set; }

        public string AccessibilityFeatures { get; set; }
    }
}
