using BlazorComponent.Models;

namespace BlazorComponent.Repositories
{
    public interface IMedicoRepositories
    {
        Task<List<Medico>> GetAllAsync();
    }
}
