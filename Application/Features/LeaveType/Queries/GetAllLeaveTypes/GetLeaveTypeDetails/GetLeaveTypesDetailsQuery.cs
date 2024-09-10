using MediatR;

namespace Application.Features.LeaveType.Queries.GetAllLeaveTypes.GetLeaveTypeDetails;

public record GetLeaveTypeDetailsQuery(int Id) : IRequest<LeaveTypeDetailsDto>;
