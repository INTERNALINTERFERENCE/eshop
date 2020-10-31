using Microsoft.EntityFrameworkCore;
using Shop.Core.Entitites;

namespace Shop.Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) 
            : base(options){}

        private DbSet<Product> Products { get; set; }
    }
}