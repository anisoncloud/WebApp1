using WebApplication1.Contract;
using WebApplication1.Models;

namespace WebApplication1.IServices
{
    public interface IUnitOfWrk : IDisposable
    {
        IRepository<Category> Categories { get; }
        IRepository<Product> Products { get; }
        Task<int> CommitAsync();
        Task RollBackAsync();
    }
}
