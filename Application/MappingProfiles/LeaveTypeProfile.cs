using Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using AutoMapper;

namespace Application.MappingProfiles;

public class LeaveTypeProfile : Profile
{
    public LeaveTypeProfile()
    {
      CreateMap<LeaveTypeDto, LeaveTypeDto>().ReverseMap();
    }
}
