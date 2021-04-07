using System;

namespace ShopAoQuan.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ShopAoQuanDbContext Init();
    }
}