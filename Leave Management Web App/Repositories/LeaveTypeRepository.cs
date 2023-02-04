using Leave_Management_Web_App.Contracts;
using Leave_Management_Web_App.Data;

namespace Leave_Management_Web_App.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
