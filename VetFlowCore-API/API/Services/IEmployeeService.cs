using Veterinarian_Management_System_API.Business.Models;
using Veterinarian_Management_System_API.Infrastructure.Data.Context;

namespace VetFlowCore_API.API.Services
{
    public interface IEmployeeService
    {
        public Task<List<Employee>> GetEmployeesForOrganization(int? orgId);





    }
}
