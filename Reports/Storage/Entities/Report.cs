using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reports.Storage.Entities
{
    public class Report
    {
        [Key]
        public int ReportId { get; set; }
        public string? ReportName { get; set; }
        public string? ReportType { get; set; }
        public string? ReportDescription { get; set; }
        public DateTime Deadline { get; set; }
        public string? Status { get; set; }

        [ForeignKey("USER")]
        public int AssignedTo { get; set; }
        public User? User { get; set; }
    }
}
