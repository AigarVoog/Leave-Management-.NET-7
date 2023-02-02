using AutoMapper;
using Leave_Management_Web_App.Data;
using Leave_Management_Web_App.Models;

namespace Leave_Management_Web_App.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
