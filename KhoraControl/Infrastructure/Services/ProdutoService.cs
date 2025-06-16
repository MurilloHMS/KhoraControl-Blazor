using KhoraControl.Domain.Models;
using KhoraControl.Infrastructure.Interfaces;

namespace KhoraControl.Infrastructure.Services;

public class ProdutoService
{
    private readonly IRepository<Produto> _repository;

    public ProdutoService(IRepository<Produto> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Produto>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }
}