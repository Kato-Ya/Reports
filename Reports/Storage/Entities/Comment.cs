namespace Reports.Storage.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string? CommentText { get; set; }
        public int ReportId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
