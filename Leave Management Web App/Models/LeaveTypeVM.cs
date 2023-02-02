using System.ComponentModel.DataAnnotations;

namespace Leave_Management_Web_App.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        

        [Display(Name = "Leave Type")]
        [Required]
        public string Name { get; set; }
        

        [Display(Name = "Default Number of Days")]
        [Required]
        [Range(1, 180, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int DefaultDays { get; set; }
    }
}
