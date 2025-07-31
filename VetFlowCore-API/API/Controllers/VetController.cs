using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Veterinarian_Management_System_API.Infrastructure.Data.Context;

namespace Veterinarian_Management_System_API.API.Controllers
{
    public class VetController: ControllerBase
    {
        private readonly AppDbContext _context;

        public VetController (AppDbContext context)
        {
            _context = context; 
        }

        [HttpGet("test-connection")]
        public async Task<IActionResult> GetOwners()
        {
            try
            {
                var Owners =  _context.Owner.ToList();
                return Ok(Owners);
            }
            catch(Exception ex) {
                return StatusCode(500, $"Connection failed: {ex.Message}");
            }
        }


    }
}
