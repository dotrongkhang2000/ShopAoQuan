using ShopAoQuan.Data.Infrastructure;
using ShopAoQuan.Model.Models;

namespace ShopAoQuan.Data.Repositories
{ 
    public interface IProductRepository : IRepository<Product>
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}