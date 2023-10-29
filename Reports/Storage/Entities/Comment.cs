using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reports.Storage.Entities
{
    [Table("COMMENT")]
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string? CommentText { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("REPORT")]
        public int ReportId { get; set; }
        public Report? Report { get; set; }

        [ForeignKey("USER")]
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
