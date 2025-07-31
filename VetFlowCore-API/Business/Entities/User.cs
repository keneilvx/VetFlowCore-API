using System.ComponentModel.DataAnnotations;

namespace Veterinarian_Management_System_API.Business.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required, MaxLength(100)]
        public string Username { get; set; } = null!;

        [Required, MaxLength(100)]
        public string Email { get; set; } = null!;

        [Required, MaxLength(512)]
        public string PasswordHash { get; set; } = null!;

        public bool IsActive { get; set; } = true;

        public DateTime? LastLogin { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
