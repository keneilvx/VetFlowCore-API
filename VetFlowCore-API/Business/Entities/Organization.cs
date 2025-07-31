using System.ComponentModel.DataAnnotations;

namespace Veterinarian_Management_System_API.Business.Models
{
    public class Organization
    {
        [Key]
        public int OrganizationID { get; set; }

        [MaxLength(100)]
        public string? OrganizationName { get; set; }

        [MaxLength(100)]
        public string? OrgType { get; set; }

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
    }
}
