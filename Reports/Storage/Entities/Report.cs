namespace Reports.Storage.Entities
{
    public class Report
    {
        public int ReportId { get; set; }
        public string? ReportName { get; set; }
        public string? ReportType { get; set; }
        public string? ReportDescription { get; set; }
        public int AssignedTo { get; set; }
        public DateTime Deadline { get; set; }
        public string? Status { get; set; }

    }
}
