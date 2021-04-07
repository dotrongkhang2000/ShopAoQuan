using ShopAoQuan.Data.Infrastructure;
using ShopAoQuan.Model.Models;

namespace ShopAoQuan.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    {
    }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}