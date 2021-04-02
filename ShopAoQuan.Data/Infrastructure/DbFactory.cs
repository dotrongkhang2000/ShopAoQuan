namespace ShopAoQuan.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopAoQuanDbContext dbContext;

        public ShopAoQuanDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopAoQuanDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}