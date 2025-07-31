using System.ComponentModel.DataAnnotations;

namespace Veterinarian_Management_System_API.Business.Models
{
    public class Owner
    {
        [Key]
        public int OwnerID { get; set; }

        [MaxLength(100)]
        public string FirstName { get; set; } = null!;

        [MaxLength(100)]
        public string LastName { get; set; } = null!;

        [MaxLength(20)]
        public string? Phone { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(200)]
        public string? AddressLine1 { get; set; }

        [MaxLength(200)]
        public string? AddressLine2 { get; set; }

        [MaxLength(100)]
        public string? City { get; set; }

        [MaxLength(20)]
        public string? Postcode { get; set; }

        [MaxLength(100)]
        public string? Country { get; set; }

        public string? Notes { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        // Navigation
        public ICollection<Animal> Animals { get; set; } = new List<Animal>();
    }
}
