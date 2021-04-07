 using ShopAoQuan.Data.Infrastructure;
using ShopAoQuan.Model.Models;

namespace ShopAoQuan.Data.Repositories
{
    public interface ITagRepository : IRepository<Tag>
    {
    }

    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}