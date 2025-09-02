using Veterinarian_Management_System_API.Infrastructure.Data.Context;
using Veterinarian_Management_System_API.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace VetFlowCore_API.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Employee>> GetEmployeesForOrganization(int? orgId )
        {
            if ( orgId.HasValue )
            {
                return await _appDbContext.Employee.Where(x => x.OrganizationID == orgId).ToListAsync();
            }
            return await _appDbContext.Employee.ToListAsync();
        }
    }
}
