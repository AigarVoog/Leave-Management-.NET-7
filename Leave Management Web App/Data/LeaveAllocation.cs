using System.ComponentModel.DataAnnotations.Schema;

namespace Leave_Management_Web_App.Data
{
    public class LeaveAllocation : BaseEntity
    {        
        public int NumberOfDays { get; set; }
        public string EmployeeId { get; set; }
        

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }        
        public int LeaveTypeId { get; set; }      
    }
}
