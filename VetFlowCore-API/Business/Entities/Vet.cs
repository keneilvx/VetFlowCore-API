namespace Veterinarian_Management_System_API.Business.Models
{
    public class Vet
    {
        public int VetId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Specialty { get; set; }
        public string LicenseNumber { get; set; }
    }
}
