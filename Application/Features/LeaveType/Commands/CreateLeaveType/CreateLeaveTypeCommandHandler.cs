using Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveType.Commands.CreateLeaveType;

public class CreateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository) : IRequestHandler<CreateLeaveTypeCommand, int>
{
    public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        var leaveTypeToCreate = mapper.Map<Domain.LeaveType>(request);
        await leaveTypeRepository.CreateAsync(leaveTypeToCreate);
        return leaveTypeToCreate.Id;
    }
}
