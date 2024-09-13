using Domain;

namespace Application.Contracts.Persistence
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocation> GetLeaveAllocationWitDetails(int id);
        Task<List<LeaveAllocation>> GetLeaveAllocationWitDetails();
        Task<List<LeaveAllocation>> GetLeaveAllocationWitDetails(string userId);
        Task<bool> AllocationExists(string userId, int leaveTypeId, int period);
        Task AddAllocations(List<LeaveAllocation> allocations);
        Task<LeaveAllocation> GetUserAllocations(string userId, int leaveTypeId);
    }
}
