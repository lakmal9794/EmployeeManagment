using EmployeeManagement.Shared;

namespace EmployeeManagment.Services
{
    public class DepartmentService:ServiceBase<Department>
    {
        public DepartmentService(ApplicationDbContext context):base(context)
        {
            
        }
    }
}
