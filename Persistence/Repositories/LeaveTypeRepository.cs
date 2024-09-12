using Application.Contracts.Persistence;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence.DatabaseContext;

namespace Persistence.Repositories;

public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
{
    public LeaveTypeRepository(HRDatabaseContext context) : base(context)
    {
    }

    public Task<bool> IsLeaveTypeUnique(string name)
    {
        return _context.LeaveTypes.AnyAsync(x => x.Name == name);
    }
}
