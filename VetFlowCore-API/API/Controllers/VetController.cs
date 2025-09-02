using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Veterinarian_Management_System_API.Business.Models;
using Veterinarian_Management_System_API.Infrastructure.Data.Context;
using VetFlowCore_API.API.Services;

namespace Veterinarian_Management_System_API.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Vets")]
    public class VetController: ControllerBase
    {
       
        private readonly AppDbContext _context;
        private readonly IEmployeeService _employeeService;

        public VetController (AppDbContext context, IEmployeeService employeeService)
        {
            _context = context;
            _employeeService = employeeService;
        }

        [HttpGet("All/{orgId?}")]
        public async Task<IActionResult> GetVets(int? orgId)
        {
            var vets = new List<Employee>();
            try
            {
                
                if (orgId.HasValue) {
                     vets = _context.Employee.Where( x => x.OrganizationID == orgId).ToList();
                }
                else
                {
                    vets = _context.Employee.ToList();
                }

                vets = await _employeeService.GetEmployeesForOrganization(orgId);

                return Ok(vets);
            }
            catch(Exception ex) {
                return StatusCode(500, $"Connection failed: {ex.Message}");
            }
        }


    }
}
