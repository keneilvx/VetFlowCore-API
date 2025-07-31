using System.ComponentModel.DataAnnotations;
using VetFlowCore_API.Business.Entities;

namespace Veterinarian_Management_System_API.Business.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [MaxLength(100)]
        public string? FirstName { get; set; }

        [MaxLength(100)]
        public string? LastName { get; set; }

        [MaxLength(20)]
        public string? Phone { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(100)]
        public string? Title { get; set; }

        [MaxLength(100)]
        public string? Specialty { get; set; }

        [MaxLength(100)]
        public string? Position { get; set; }

        [MaxLength(50)]
        public string? LicenseNumber { get; set; }

        // Navigation
        public ICollection<Visit>? Visits { get; set; }
        public ICollection<MedicalNote>? MedicalNotesEntered { get; set; }
    }
}
