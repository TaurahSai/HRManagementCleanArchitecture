using Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using Application.Features.LeaveType.Queries.GetAllLeaveTypes.GetLeaveTypeDetails;
using AutoMapper;
using Domain;

namespace Application.MappingProfiles;

public class LeaveTypeProfile : Profile
{
    public LeaveTypeProfile()
    {
      CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
      CreateMap<LeaveType, LeaveTypeDetailsDto>();
    }
}
