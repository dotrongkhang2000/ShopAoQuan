namespace ShopAoQuan.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactoty dbFactory;
        private ShopQuanAoDbContext dbContext;

        public UnitOfWork(IDbFactoty dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public ShopQuanAoDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}