using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reports.Storage.Entities
{
    public class ParameterReport
    {
        public string? ParameterName { get; set; }
        public string? ParameterValue { get; set; }

        [ForeignKey("REPORT")]
        public int ReportId { get; set; }
        public Report? Report { get; set; }  
    }
}
