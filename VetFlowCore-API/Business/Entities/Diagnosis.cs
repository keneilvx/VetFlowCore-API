using System.ComponentModel.DataAnnotations;

namespace Veterinarian_Management_System_API.Business.Models
{
    public class Diagnosis
    {
        [Key]
        public int DiagnosisID { get; set; }

        [Required, MaxLength(150)]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        [MaxLength(20)]
        public string? ICDCode { get; set; }

        // Navigation
        public ICollection<Visit>? Visits { get; set; }
    }
}
