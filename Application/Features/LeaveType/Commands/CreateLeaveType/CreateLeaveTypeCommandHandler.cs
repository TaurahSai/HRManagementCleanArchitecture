using Application.Contracts.Persistence;
using Application.Exceptions;
using AutoMapper;
using MediatR;

namespace Application.Features.LeaveType.Commands.CreateLeaveType;

public class CreateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository) : IRequestHandler<CreateLeaveTypeCommand, int>
{
    public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateLeaveTypeCommandValidator(leaveTypeRepository);
        var validationResult = await validator.ValidateAsync(request, CancellationToken.None);

        if (validationResult.Errors.Count != 0)
            throw new BadRequestException("Invalid LeaveType", validationResult);

        var leaveTypeToCreate = mapper.Map<Domain.LeaveType>(request);

        await leaveTypeRepository.CreateAsync(leaveTypeToCreate);

        return leaveTypeToCreate.Id;
    }
}
