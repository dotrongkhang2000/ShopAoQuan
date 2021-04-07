using ShopAoQuan.Data.Infrastructure;
using ShopAoQuan.Model.Models;

namespace ShopAoQuan.Data.Repositories
{
    public interface IFooterRepository : IRepository<Footer>
    {
    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}