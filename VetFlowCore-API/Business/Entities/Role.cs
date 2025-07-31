using System.ComponentModel.DataAnnotations;

namespace VetFlowCore_API.Business.Entities
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; } = null!;

        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
