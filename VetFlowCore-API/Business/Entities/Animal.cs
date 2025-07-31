using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Veterinarian_Management_System_API.Business.Enums;

namespace Veterinarian_Management_System_API.Business.Models
{
    public class Animal
    {
        [Key]
        public int AnimalID { get; set; }

        [ForeignKey(nameof(Owner))]
        public int OwnerID { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(50)]
        public string? Species { get; set; }

        [MaxLength(100)]
        public string? Breed { get; set; }

        [MaxLength(20)]
        public string? Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [MaxLength(50)]
        public string? Color { get; set; }

        [MaxLength(50)]
        public string? MicrochipNumber { get; set; }

        public decimal? WeightKg { get; set; }

        public DateTime DateRegistered { get; set; } = DateTime.Now;

        [MaxLength(20)]
        public string? Status { get; set; }

        // Navigation
        public Owner Owner { get; set; } = null!;
        public ICollection<Visit> Visits { get; set; } = new List<Visit>();
    }

}
