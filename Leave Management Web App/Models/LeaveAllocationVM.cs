namespace Leave_Management_Web_App.Models
{
    public class LeaveAllocationVM
    {
        public int Id { get; set; }
        public int NumberOfDays { get; set; }
        public LeaveTypeVM LeaveType { get; set; }
        public int Period { get; set; }
    }
}