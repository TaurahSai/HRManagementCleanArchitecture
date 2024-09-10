using Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveType.Queries.GetLeaveTypeDetails;

public class GetLeaveTypeDetailsQueryHandler(IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository) : IRequestHandler<GetLeaveTypeDetailsQuery, LeaveTypeDetailsDto>
{
    public async Task<LeaveTypeDetailsDto> Handle(GetLeaveTypeDetailsQuery request, CancellationToken cancellationToken)
    {
        var leavesTypes = await leaveAllocationRepository.GetByIdAsync(request.Id);

        var data = mapper.Map<LeaveTypeDetailsDto>(leavesTypes);

        return data;
    }
}
