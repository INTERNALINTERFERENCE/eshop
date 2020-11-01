using System.Collections.Generic;
using System.Threading.Tasks;
using Shop.Core.Entitites;
using Shop.Core.Interfaces;

namespace Shop.Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        public Task<Product> GetProductByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyList<Product>> GetProductAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}