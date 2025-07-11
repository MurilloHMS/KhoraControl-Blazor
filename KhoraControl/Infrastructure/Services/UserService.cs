using KhoraControl.Domain.Models;
using KhoraControl.Domain.Models.Entities;
using KhoraControl.Infrastructure.Interfaces;

namespace KhoraControl.Infrastructure.Services;

public class UserService
{
    private readonly IRepository<UserAccount> _repositoryUserAccount;
    private readonly IUserAccountPolicyRepository _repositoryUserPolicy;

    public UserService(IRepository<UserAccount> repositoryUserAccount, IUserAccountPolicyRepository repositoryUserPolicy)
    {
        _repositoryUserAccount = repositoryUserAccount;
        _repositoryUserPolicy = repositoryUserPolicy;
    }

    public async Task<IEnumerable<UserAccount>> GetAllUsersAsync()
    {
        return await _repositoryUserAccount.GetAllAsync();
    }

    public async Task AddUserAsync(UserAccount userAccount)
    {
        await _repositoryUserAccount.InsertAsync(userAccount);
    }

    public async Task UpdateUserAsync(UserAccount userAccount)
    {
        await _repositoryUserAccount.UpdateAsync(userAccount);
    }

    public async Task DeleteUserAsync(UserAccount userAccount)
    {
        await _repositoryUserAccount.DeleteAsync(userAccount);
    }
    
    public async Task<IEnumerable<UserAccountPolicy>> GetUserAccountPoliciesAsync(int userId)
    {
        return await _repositoryUserPolicy.GetUserAccountPoliciesAsync(userId);
    }

    public async Task AddUserAccountPolicyAsync(UserAccountPolicy userAccountPolicy)
    {
        await _repositoryUserPolicy.InsertAsync(userAccountPolicy);
    }

    public async Task UpdateUserAccountPolicyAsync(UserAccountPolicy userAccountPolicy)
    {
        await _repositoryUserPolicy.UpdateAsync(userAccountPolicy);
    }

    public async Task DeleteUserAccountPolicyAsync(UserAccountPolicy userAccountPolicy)
    {
        await _repositoryUserPolicy.DeleteAsync(userAccountPolicy);
    }
}