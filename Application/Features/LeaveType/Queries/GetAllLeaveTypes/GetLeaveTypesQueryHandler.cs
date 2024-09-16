using Application.Contracts.Logging;
using Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveType.Queries.GetAllLeaveTypes;

public class GetLeaveTypesQueryHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository, IAppLogger<GetLeaveTypesQueryHandler> logger) : IRequestHandler<GetLeaveTypesQuery, List<LeaveTypeDto>>
{
    public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypesQuery request, CancellationToken cancellationToken)
    {
        var leaveTypes = await leaveTypeRepository.GetAsync();

        var data = mapper.Map<List<LeaveTypeDto>>(leaveTypes);

        logger.LogInformation("Leave types were retrieved successfully");

        return data;
    }
}
