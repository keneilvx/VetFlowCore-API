using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VetFlowCore_API.Business.Entities;

namespace Veterinarian_Management_System_API.Business.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        public int? OrganizationID { get; set; }

        public int RoleId {  get; set; }

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
        [ForeignKey(nameof(Organization))]
        public Organization? Organization { get; set; }

        [ForeignKey(nameof(Role))]
        public Role? Role { get; set; }
    }
}
