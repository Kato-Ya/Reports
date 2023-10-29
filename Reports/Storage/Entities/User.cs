using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reports.Storage.Entities
{
    public class User : IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Login { get; set; }
        public string? Status { get; set; }

        [ForeignKey("ROLE")]
        public int RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
