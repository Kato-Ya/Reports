using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reports.Storage.Entities
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
    }
}
