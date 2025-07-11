using KhoraControl.Domain.Models.Entities;

namespace KhoraControl.Infrastructure.Interfaces;

public interface IUserAccountPolicyRepository : IRepository<UserAccountPolicy>
{
    Task<IEnumerable<UserAccountPolicy>> GetUserAccountPoliciesAsync(int userId);
}