using System.Collections.Generic;
using System.Threading.Tasks;
using Shop.Core.Entitites;

namespace Shop.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductAsync();
    }
}