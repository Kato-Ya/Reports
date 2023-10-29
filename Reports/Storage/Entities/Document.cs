using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reports.Storage.Entities
{
    public class Document
    {
        [Key]
        public int DocumentId { get; set; }
        public string? DocumentName { get; set; }
        public byte DocumentFile { get; set; }

        [ForeignKey("REPORT")]
        public int ReportId { get; set; }
        public Report? Report { get; set; }
    }
}
