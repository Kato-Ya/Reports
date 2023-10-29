using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reports.Storage.Entities
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsRead { get; set; }
        public string? NotificationName { get; set; }

        [ForeignKey("USER")]
        public int UserId { get; set; }
        public User? User { get; set; }

    }
}
