using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAoQuan.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopQuanAoDbContext dbContext;

        public ShopQuanAoDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopQuanAoDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
