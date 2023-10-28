namespace Reports.Storage.Entities
{
    public class Document
    {
        public int DocumentId { get; set; }
        public string? DocumentName { get; set; }
        public int ReportId { get; set; }
        public byte DocumentFile { get; set; }
    }
}
