using System.Data;
using Veterinarian_Management_System_API.Business.Models;

namespace VetFlowCore_API.Business.Entities
{
    public class UserRole
    {

        public int UserID { get; set; }
        public User? User { get; set; } = null!;

        public int RoleID { get; set; }
        public Role? Role { get; set; } = null!;
    }
}
