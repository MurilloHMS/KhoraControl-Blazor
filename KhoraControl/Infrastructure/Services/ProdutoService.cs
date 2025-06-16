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

    public async Task<Produto> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task SaveAsync(Produto produto)
    {
        await _repository.InsertAsync(produto);
    }

    public async Task UpdateAsync(Produto produto)
    {
        await _repository.UpdateAsync(produto);
    }

    public async Task DeleteAsync(Produto produto)
    {
        await _repository.DeleteAsync(produto);
    }
}