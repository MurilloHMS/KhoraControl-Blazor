using KhoraControl.Domain.Data;
using KhoraControl.Domain.Models.Entities;
using KhoraControl.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KhoraControl.Infrastructure.Repositories;

public class UserAccountPolicyRepository : Repository<UserAccountPolicy>, IUserAccountPolicyRepository
{
    private readonly AppDbContext _context;

    public UserAccountPolicyRepository(AppDbContext context) : base(context) { }

    public async Task<IEnumerable<UserAccountPolicy>> GetUserAccountPoliciesAsync(int userId)
    {
        return await _dbSet.Where(x => x.UserAccountId == userId).ToListAsync();
    }
}