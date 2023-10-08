using EmployeeManagement.Shared;

namespace EmployeeManagment.Services
{
    public class EmployeeService:ServiceBase<Employee>
    {
        public EmployeeService(ApplicationDbContext context):base(context)
        {
            
        }
    }
}
