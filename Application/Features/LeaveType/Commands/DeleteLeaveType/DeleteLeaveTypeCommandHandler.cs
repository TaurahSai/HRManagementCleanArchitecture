using Application.Contracts.Persistence;
using MediatR;

namespace Application.Features.LeaveType.Commands.DeleteLeaveType;

internal class DeleteLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository) : IRequestHandler<DeleteLeaveTypeCommand, Unit>
{
    public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        var leaveTypeToDelete = await leaveTypeRepository.GetByIdAsync(request.Id);

        await leaveTypeRepository.DeleteAsync(leaveTypeToDelete);

        return Unit.Value;
    }
}
